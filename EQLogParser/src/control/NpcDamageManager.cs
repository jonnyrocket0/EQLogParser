﻿using System;
using System.Globalization;

namespace EQLogParser
{
  class NpcDamageManager
  {
    public static event EventHandler<DamageProcessedEvent> EventsPlayerAttackProcessed;

    internal double LastFightProcessTime = double.NaN;
    private int CurrentNpcID = 0;

    public NpcDamageManager()
    {
      DamageLineParser.EventsDamageProcessed += HandleDamageProcessed;
    }

    ~NpcDamageManager()
    {
      DamageLineParser.EventsDamageProcessed -= HandleDamageProcessed;
    }

    internal void ResetTime()
    {
      LastFightProcessTime = double.NaN;
    }

    private void HandleDamageProcessed(object sender, DamageProcessedEvent processed)
    {
      if (LastFightProcessTime != processed.BeginTime)
      {
        DataManager.Instance.CheckExpireFights(processed.BeginTime);
      }

      if (IsValidAttack(processed.Record, out bool defender, out bool isSpell))
      {
        string origTimeString = processed.OrigTimeString.Substring(4, 15);

        Fight fight = Get(processed.Record, processed.BeginTime, origTimeString, defender, isSpell);

        if (defender)
        {
          Helpers.AddAction(fight.DamageBlocks, processed.Record, processed.BeginTime);
          AddPlayerTime(fight, processed.Record, processed.Record.Attacker, processed.BeginTime);
          fight.Total += processed.Record.Total;
          fight.BeginDamageTime = double.IsNaN(fight.BeginDamageTime) ? processed.BeginTime : fight.BeginDamageTime;
          fight.LastDamageTime = processed.BeginTime;
          fight.DamageHits++;
        }
        else
        {
          Helpers.AddAction(fight.TankingBlocks, processed.Record, processed.BeginTime);
          AddPlayerTime(fight, processed.Record, processed.Record.Defender, processed.BeginTime);
          fight.BeginTankingTime = double.IsNaN(fight.BeginTankingTime) ? processed.BeginTime : fight.BeginTankingTime;
          fight.LastTankingTime = processed.BeginTime;
          fight.TankHits++;
        }

        fight.LastTime = processed.BeginTime;
        LastFightProcessTime = processed.BeginTime;

        var ttl = fight.LastTime - fight.BeginTime + 1;
        fight.TooltipText = string.Format(CultureInfo.CurrentCulture, "#Hits To Players: {0}, #Hits From Players: {1}, Time Alive: {2}s", fight.TankHits, fight.DamageHits, ttl);

        DataManager.Instance.UpdateIfNewFightMap(fight.CorrectMapKey, fight);

        if (defender)
        {
          EventsPlayerAttackProcessed?.Invoke(processed.Record, processed);
        }
      }
  }

    private Fight Get(DamageRecord record, double currentTime, string origTimeString, bool defender, bool isSpell)
    {
      string npc = defender ? record.Defender : record.Attacker;

      Fight fight = DataManager.Instance.GetFight(npc);
      if (fight == null)
      {
        fight = Create(npc, currentTime, origTimeString, isSpell);
      }

      return fight;
    }

    private Fight Create(string defender, double currentTime, string origTimeString, bool isSpell)
    {
      return new Fight()
      {
        Name = string.Intern(defender),
        BeginTimeString = string.Intern(origTimeString),
        BeginTime = currentTime,
        LastTime = currentTime,
        Id = CurrentNpcID++,
        IsSpell = isSpell,
        CorrectMapKey = string.Intern(defender)
      };
    }

    private static void AddPlayerTime(Fight fight, DamageRecord record, string player, double time)
    {
      var isInitialTanking = fight.DamageBlocks.Count == 0;
      var segments = isInitialTanking ? fight.InitialTankSegments : fight.DamageSegments;
      var subSegments = isInitialTanking ? fight.InitialTankSubSegments : fight.DamageSubSegments;
      StatsUtil.UpdateTimeSegments(segments, subSegments, Helpers.CreateRecordKey(record.Type, record.SubType), player, time);
    }

    private static bool IsValidAttack(DamageRecord record, out bool npcDefender, out bool isSpell)
    {
      bool valid = false;
      npcDefender = false;
      isSpell = false;

      if (!record.Attacker.Equals(record.Defender, StringComparison.OrdinalIgnoreCase))
      {
        var attackerSpell = DataManager.Instance.GetSpellByName(record.Attacker);
        var defenderSpell = DataManager.Instance.GetSpellByName(record.Defender);

        var isAttackerPlayer = record.Attacker == Labels.UNK || PlayerManager.Instance.IsPetOrPlayer(record.Attacker);
        var isDefenderPlayer = record.Attacker == Labels.UNK || PlayerManager.Instance.IsPetOrPlayer(record.Defender);
        var isAttackerNpc = !isAttackerPlayer && (DataManager.Instance.IsKnownNpc(record.Attacker) 
          || (attackerSpell != null && attackerSpell.IsBeneficial == false));
        var isDefenderNpc = !isDefenderPlayer && (DataManager.Instance.IsKnownNpc(record.Defender) 
          || (defenderSpell != null && defenderSpell.IsBeneficial == false));

        isSpell = attackerSpell != null && !attackerSpell.IsBeneficial;

        if (isDefenderNpc && !isAttackerNpc)
        {
          valid = isAttackerPlayer || PlayerManager.Instance.IsPossiblePlayerName(record.Attacker);
          npcDefender = true;
        }
        else if (!isDefenderNpc && isAttackerNpc)
        {
          valid = true;
          npcDefender = false;
        }
        else if (!isDefenderNpc && !isAttackerNpc)
        {
          if (isDefenderPlayer || isAttackerPlayer)
          {
            valid = isDefenderPlayer != isAttackerPlayer;
            if (!valid)
            {
              if (PlayerManager.Instance.IsCharmPet(record.Attacker))
              {
                valid = true;
                npcDefender = false;
              }
              else if (PlayerManager.Instance.IsCharmPet(record.Defender))
              {
                valid = true;
                npcDefender = true;
              }
            }
            else
            {
              npcDefender = !isDefenderPlayer;
            }
          }
          else
          {
            npcDefender = PlayerManager.Instance.IsPossiblePlayerName(record.Attacker) || !PlayerManager.Instance.IsPossiblePlayerName(record.Defender);
            valid = true;
          }
        }
        else if (isDefenderNpc && isAttackerNpc && DataManager.Instance.GetFight(record.Defender) != null
          && DataManager.Instance.GetFight(record.Attacker) == null)
        {
          valid = true;
          npcDefender = true;
        }
      }

      return valid;
    }
  }
}
