﻿using System.Collections.Generic;

namespace EQLogParser
{
  public enum SpellClasses
  {
    WAR = 1, CLR = 2, PAL = 4, RNG = 8, SHD = 16, DRU = 32, MNK = 64, BRD = 128, ROG = 256,
    SHM = 512, NEC = 1024, WIZ = 2048, MAG = 4096, ENC = 8192, BST = 16384, BER = 32768
  }

  public enum SpellTarget
  {
    LOS = 1, CASTER_AE = 2, CASTER_GROUP = 3, CASTER_PB = 4, SINGLE = 5, SELF = 6, TARGET_AE = 8,
    NEARBY_PLAYERS_AE = 40, DIRECTION_AE = 42, TARGET_RING_AE = 45
  }

  public static class Labels
  {
    public const string DD_NAME = "Direct Damage";
    public const string DOT_NAME = "DoT Tick";
    public const string DS_NAME = "Damage Shield";
    public const string BANE_NAME = "Bane Damage";
    public const string PROC_NAME = "Proc";
    public const string RESIST_NAME = "Resisted Spells";
    public const string HOT_NAME = "HoT Tick";
    public const string HEAL_NAME = "Heal";
    public const string UNASSIGNED_PET_OWNER = "Unknown Pet Owner";
    public const string UNKNOWN_SPELL = "Unknown Spell";
    public const string UNKNOWN_PLAYER = "Unknown Player";
  }

  public class Action
  {

  }

  public class TimedAction : Action
  {
    public double BeginTime { get; set; }
  }

  public class FullTimedAction : TimedAction
  {
    public double LastTime { get; set; }
  }

  public class DamageProcessedEvent : TimedAction
  {
    public DamageRecord Record { get; set; }
    public string TimeString { get; set; }
  }

  public class HealProcessedEvent : TimedAction
  {
    public HealRecord Record { get; set; }
  }

  public class ResistProcessedEvent : TimedAction
  {
    public ResistRecord Record { get; set; }
  }

  public class DataPointEvent
  {
    public DataPoint Data { get; set; }
    public string EventType { get; set; }
    public bool ShowBane { get; set; }
    public bool ShowAE { get; set; }
  }

  public class ProcessLine
  {
    public string Line { get; set; }
    public double CurrentTime { get; set; }
    public string TimeString { get; set; }
    public string ActionPart { get; set; }
    public int OptionalIndex { get; set; }
    public string OptionalData { get; set; }
  }

  public class ResistRecord : Action
  {
    public string Spell { get; set; }
  }

  public class HitRecord : Action
  {
    public uint Total { get; set; }
    public uint OverTotal { get; set; }
    public string Type { get; set; }
    public string SubType { get; set; }
    public int ModifiersMask { get; set; }
  }

  public class HealRecord : HitRecord
  {
    public string Healer { get; set; }
    public string Healed { get; set; }
  }

  public class DamageRecord : HitRecord
  {
    public string Attacker { get; set; }
    public string AttackerOwner { get; set; }
    public string Defender { get; set; }
    public string DefenderOwner { get; set; }
  }

  public class ActionBlock : TimedAction
  {
    public List<Action> Actions { get; set; }
  }

  public class Hit : FullTimedAction
  {
    public uint Max { get; set; }
    public uint BaneHits{ get; set; }
    public uint Hits { get; set; }
    public uint CritHits { get; set; }
    public uint LuckyHits { get; set; }
    public uint TwincastHits { get; set; }
    public long Total { get; set; }
    public long TotalCrit { get; set; }
    public long TotalLucky { get; set; }
    public Dictionary<long, int> CritFreqValues { get; set; }
    public Dictionary<long, int> NonCritFreqValues { get; set; }
  }

  public class NonPlayer : FullTimedAction
  {
    public const string BREAK_TIME = "Break Time";
    public string BeginTimeString { get; set; }
    public string Name { get; set; }
    public int ID { get; set; }
    public string CorrectMapKey {get; set;}
    public int GroupID { get; set; }
  }

  public class PetMapping
  {
    public string Owner { get; set; }
    public string Pet { get; set; }
  }

  public class SortableName
  {
    public string Name { get; set; }
  }

  public class PlayerDeath : Action
  {
    public string Player { get; set; }
    public string Npc { get; set; }
  }

  public class ReceivedSpell : Action
  {
    public string Receiver { get; set; }
    public SpellData SpellData { get; set; }
  }

  public class SpellCast : ReceivedSpell
  {
    public string Spell { get; set; }
    public string Caster { get; set; }
  }

  public class SpellData
  {
    public string ID { get; set; }
    public string Spell { get; set; }
    public string SpellAbbrv { get; set; }
    public bool Beneficial { get; set; }
    public byte Target { get; set; }
    public ushort ClassMask { get; set; }
    public string LandsOnYou { get; set; }
    public string LandsOnOther { get; set; }
    public bool Damaging { get; set; }
    public bool IsProc { get; set; }
  }

  public class SpellCountData
  {
    public Dictionary<string, Dictionary<string, uint>> PlayerCastCounts { get; set; }
    public Dictionary<string, Dictionary<string, uint>> PlayerReceivedCounts { get; set; }
    public Dictionary<string, uint> MaxCastCounts { get; set; }
    public Dictionary<string, uint> MaxReceivedCounts { get; set; }
    public Dictionary<string, SpellData> UniqueSpells { get; set; }
  }

  public class SpellCountRow
  {
    public string Spell { get; set; }
    public double[] Values { get; set; }
    public bool IsReceived { get; set; }
  }

  public class CombinedStats
  {
    public string TargetTitle { get; set; }
    public string TimeTitle { get; set; }
    public string TotalTitle { get; set; }
    public List<PlayerStats> StatsList { get; set; }
    public PlayerStats RaidStats { get; set; }
  }

  public class CombinedDamageStats : CombinedStats
  {
    public Dictionary<string, List<PlayerStats>> Children { get; set; }
    public Dictionary<string, byte> UniqueClasses { get; set; }
  }

  public class CombinedHealStats : CombinedStats
  {
    public Dictionary<string, byte> UniqueClasses { get; set; }
  }

  public class OverlayDamageStats : CombinedStats
  {
    public Dictionary<string, PlayerStats> TopLevelStats { get; set; }
    public Dictionary<string, PlayerStats> AggregateStats { get; set; }
    public Dictionary<string, PlayerStats> IndividualStats { get; set; }
    public Dictionary<string, byte> UniqueNpcs { get; set; }
  }

  public class DataPoint
  {
    public long Avg { get; set; }
    public string Name { get; set; }
    public int ModifiersMask { get; set; }
    public long Total { get; set; }
    public long RollingTotal { get; set; }
    public uint RollingHits { get; set; }
    public uint RollingCritHits { get; set; }
    public long VPS { get; set; }
    public double CritRate { get; set; }
    public double BeginTime { get; set; }
    public double CurrentTime { get; set; }
  }

  public class HitFreqChartData
  {
    public string HitType { get; set; }
    public List<int> CritYValues { get; set; }
    public List<long> CritXValues { get; set; }
    public List<int> NonCritYValues { get; set; }
    public List<long> NonCritXValues { get; set; }
  }

  public class StatsSummary
  {
    public string Title { get; set; }
    public string ShortTitle { get; set; }
    public string RankedPlayers { get; set; }
  }

  public class PlayerSubStats : Hit
  {
    public ushort Rank { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public double TotalSeconds { get; set; }
    public long DPS { get; set; }
    public long SDPS { get; set; }
    public long Extra { get; set; }
    public uint Resists { get; set; }
    public long Avg { get; set; }
    public long AvgCrit { get; set; }
    public long AvgLucky { get; set; }
    public double CritRate { get; set; }
    public double ExtraRate { get; set; }
    public double LuckRate { get; set; }
    public double TwincastRate { get; set; }
    public double ResistRate { get; set; }
    public double Percent { get; set; }
    public double PercentOfRaid { get; set; }
    public uint Deaths { get; set; }
    public string ClassName { get; set; }
    public List<double> BeginTimes { get; set; }
    public List<double> LastTimes { get; set; }
    public List<double> TimeDiffs { get; set; }
  }

  public class PlayerStats : PlayerSubStats
  {
    public Dictionary<string, PlayerSubStats> SubStats { get; set; }
    public Dictionary<string, PlayerSubStats> SubStats2 { get; set; }
    public string OrigName { get; set; }
  }
}
