﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace EQLogParser
{
  class SpellCountBuilder
  {
    public const int COUNT_OFFSET = 15;
    internal static SpellCountData GetSpellCounts(List<string> playerList, PlayerStats raidStats)
    {
      var result = new SpellCountData();

      HashSet<IAction> castsDuring = new HashSet<IAction>();
      HashSet<IAction> receivedDuring = new HashSet<IAction>();
      for (int i = 0; i < raidStats.BeginTimes.Count; i++)
      {
        var blocks = DataManager.Instance.GetCastsDuring(raidStats.BeginTimes[i] - COUNT_OFFSET, raidStats.LastTimes[i]);
        blocks.ForEach(block => block.Actions.ForEach(action => castsDuring.Add(action)));
        blocks = DataManager.Instance.GetReceivedSpellsDuring(raidStats.BeginTimes[i] - COUNT_OFFSET, raidStats.LastTimes[i]);
        blocks.ForEach(block => block.Actions.ForEach(action => receivedDuring.Add(action)));
      }

      foreach (var action in castsDuring.AsParallel().Where(cast => playerList.Contains((cast as SpellCast).Caster)))
      {
        SpellCast cast = action as SpellCast;
        var spellData = DataManager.Instance.GetSpellByAbbrv(Helpers.AbbreviateSpellName(cast.Spell));
        if (spellData != null)
        {
          UpdateMaps(spellData, cast.Caster, result.PlayerCastCounts, result.MaxCastCounts, result.UniqueSpells);
        }
      }

      foreach (var action in receivedDuring.AsParallel().Where(received => playerList.Contains((received as ReceivedSpell).Receiver)))
      {
        ReceivedSpell received = action as ReceivedSpell;

        var spellData = received.SpellData;
        if (spellData == null && received.Ambiguity != null && DataManager.Instance.ResolveSpellAmbiguity(received, out SpellData replaced))
        {
          spellData = replaced;
        }

        if (spellData != null)
        {
          UpdateMaps(spellData, received.Receiver, result.PlayerReceivedCounts, result.MaxReceivedCounts, result.UniqueSpells);
        }
      }

      return result;
    }

    private static void UpdateMaps(SpellData theSpell, string thePlayer, Dictionary<string, Dictionary<string, uint>> playerCounts,
      Dictionary<string, uint> maxSpellCounts, Dictionary<string, SpellData> spellMap)
    {
      if (!playerCounts.ContainsKey(thePlayer))
      {
        playerCounts[thePlayer] = new Dictionary<string, uint>();
      }

      if (!playerCounts[thePlayer].ContainsKey(theSpell.ID))
      {
        playerCounts[thePlayer][theSpell.ID] = 0;
      }

      playerCounts[thePlayer][theSpell.ID]++;

      if (!maxSpellCounts.ContainsKey(theSpell.ID))
      {
        maxSpellCounts[theSpell.ID] = playerCounts[thePlayer][theSpell.ID];
      }
      else if (playerCounts[thePlayer][theSpell.ID] > maxSpellCounts[theSpell.ID])
      {
        maxSpellCounts[theSpell.ID] = playerCounts[thePlayer][theSpell.ID];
      }

      spellMap[theSpell.ID] = theSpell;
    }
  }
}
