﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EQLogParser
{
  class StatsUtil
  {
    internal const string TIME_FORMAT = "in {0}s";
    internal const string TOTAL_FORMAT = "{0}{1}@{2}";
    internal const string TOTAL_ONLY_FORMAT = "{0}";
    internal const string PLAYER_FORMAT = "{0} = ";
    internal const string PLAYER_RANK_FORMAT = "{0}. {1} = ";
    internal const int DEATH_TIME_OFFSET = 10; // seconds forward

    internal static PlayerStats CreatePlayerStats(Dictionary<string, PlayerStats> individualStats, string key, string origName = null)
    {
      PlayerStats stats = null;

      lock (individualStats)
      {
        if (!individualStats.ContainsKey(key))
        {
          stats = CreatePlayerStats(key, origName);
          individualStats[key] = stats;
        }
        else
        {
          stats = individualStats[key];
        }
      }

      return stats;
    }

    internal static PlayerStats CreatePlayerStats(string name, string origName = null)
    {
      string className = "";
      origName = origName == null ? name : origName;

      if (!DataManager.Instance.CheckNameForPet(origName))
      {
        className = DataManager.Instance.GetPlayerClass(origName);
      }

      return new PlayerStats()
      {
        Name = string.Intern(name),
        ClassName = string.Intern(className),
        OrigName = string.Intern(origName),
        Percent = 100, // until something says otherwise
        SubStats = new Dictionary<string, PlayerSubStats>(),
        BeginTime = double.NaN,
        BeginTimes = new List<double>(),
        LastTimes = new List<double>(),
        TimeDiffs = new List<double>()
      };
    }

    internal static PlayerSubStats CreatePlayerSubStats(Dictionary<string, PlayerSubStats> individualStats, string key, string type)
    {
      PlayerSubStats stats = null;

      lock (individualStats)
      {
        if (!individualStats.ContainsKey(key))
        {
          stats = CreatePlayerSubStats(key, type);
          individualStats[key] = stats;
        }
        else
        {
          stats = individualStats[key];
        }
      }

      return stats;
    }

    internal static PlayerSubStats CreatePlayerSubStats(string name, string type)
    {
      return new PlayerSubStats()
      {
        ClassName = "",
        Name = string.Intern(name),
        Type = string.Intern(type),
        CritFreqValues = new Dictionary<long, int>(),
        NonCritFreqValues = new Dictionary<long, int>(),
        BeginTime = double.NaN,
        BeginTimes = new List<double>(),
        LastTimes = new List<double>(),
        TimeDiffs = new List<double>()
      };
    }

    internal static string FormatTitle(string targetTitle, string timeTitle, string damageTitle = "")
    {
      string result;
      result = targetTitle + " " + timeTitle;
      if (damageTitle != "")
      {
        result += ", " + damageTitle;
      }
      return result;
    }

    internal static string FormatTotals(long total)
    {
      string result;

      if (total < 1000)
      {
        result = total.ToString();
      }
      else if (total < 1000000)
      {
        result = Math.Round((decimal) total / 1000, 2) + "K";
      }
      else if (total < 1000000000)
      {
        result = Math.Round((decimal) total / 1000 / 1000, 2) + "M";
      }
      else
      {
        result = Math.Round((decimal) total / 1000 / 1000 / 1000, 2) + "B";
      }

      return result;
    }

    internal static uint ParseUInt(string str)
    {
      uint y = 0;
      for (int i = 0; i < str.Length; i++)
      {
        if (!char.IsDigit(str[i]))
        {
          return uint.MaxValue;
        }

        y = y * 10 + (Convert.ToUInt32(str[i]) - '0');
      }
      return y;
    }

    internal static void UpdateTimeDiffs(PlayerSubStats subStats, FullTimedAction action, double offset = 0)
    {
      int currentIndex = subStats.BeginTimes.Count - 1;
      if (currentIndex == -1)
      {
        subStats.BeginTimes.Add(action.BeginTime);
        subStats.LastTimes.Add(action.LastTime + offset);
        subStats.TimeDiffs.Add(0); // update afterward
        currentIndex = 0;
      }
      else if (subStats.LastTimes[currentIndex] >= action.BeginTime)
      {
        var offsetLastTime = action.LastTime + offset;
        if (offsetLastTime > subStats.LastTimes[currentIndex])
        {
          subStats.LastTimes[currentIndex] = offsetLastTime;
        }
      }
      else
      {
        subStats.BeginTimes.Add(action.BeginTime);
        subStats.LastTimes.Add(action.LastTime + offset);
        subStats.TimeDiffs.Add(0); // update afterward
        currentIndex++;
      }

      subStats.TimeDiffs[currentIndex] = subStats.LastTimes[currentIndex] - subStats.BeginTimes[currentIndex] + 1;
    }

    internal static void UpdateStats(PlayerSubStats stats, HitRecord record, double beginTime)
    {
      if (record.Type == Labels.BANE_NAME)
      {
        stats.BaneHits++;
      }

      stats.Total += record.Total;
      stats.Hits += 1;
      stats.Max = Math.Max(stats.Max, record.Total);

      if (record.Total > 0 && record.OverTotal > 0)
      {
        stats.Extra += (record.OverTotal - record.Total);
      }

      LineModifiersParser.Parse(record, stats);

      stats.BeginTime = double.IsNaN(stats.BeginTime) ? beginTime : stats.BeginTime;
      stats.LastTime = beginTime;
    }

    internal static void MergeStats(PlayerSubStats to, PlayerSubStats from)
    {
      to.BaneHits += from.BaneHits;
      to.Total += from.Total;
      to.Hits += from.Hits;
      to.Max = Math.Max(to.Max, from.Max);
      to.Extra += from.Extra;
      to.CritHits += from.CritHits;
      to.LuckyHits += from.LuckyHits;
      to.TwincastHits += from.TwincastHits;
      to.BeginTime = double.IsNaN(to.BeginTime) ? from.BeginTime : Math.Min(to.BeginTime, from.BeginTime);
      to.LastTime = double.IsNaN(to.LastTime) ? from.LastTime : Math.Max(to.LastTime, from.LastTime);
    }

    internal static void UpdateCalculations(PlayerSubStats stats, PlayerStats raidTotals, Dictionary<string, uint> resistCounts = null, PlayerStats superStats = null)
    {
      if (stats.Hits > 0)
      {
        stats.Avg = (long) Math.Round(Convert.ToDecimal(stats.Total) / stats.Hits, 2);
        stats.CritRate = Math.Round(Convert.ToDouble(stats.CritHits) / stats.Hits * 100, 2);
        stats.LuckRate = Math.Round(Convert.ToDouble(stats.LuckyHits) / stats.Hits * 100, 2);

        var tcMult = stats.Type == Labels.HOT_NAME || stats.Type == Labels.DOT_NAME ? 1 : 2;
        stats.TwincastRate = Math.Round(Convert.ToDouble(stats.TwincastHits) / stats.Hits * tcMult * 100, 2);
      }

      if (stats.Total > 0)
      {
        stats.ExtraRate = Math.Round(Convert.ToDouble(stats.Extra) / stats.Total * 100, 2);
      }

      if ((stats.CritHits - stats.LuckyHits) > 0)
      {
        stats.AvgCrit = (long) Math.Round(Convert.ToDecimal(stats.TotalCrit) / (stats.CritHits - stats.LuckyHits), 2);
      }

      if (stats.LuckyHits > 0)
      {
        stats.AvgLucky = (long) Math.Round(Convert.ToDecimal(stats.TotalLucky) / stats.LuckyHits, 2);
      }

      // total percents
      if (raidTotals.Total > 0)
      {
        stats.PercentOfRaid = Math.Round(Convert.ToDouble(stats.Total) / raidTotals.Total * 100, 2);
      }

      stats.DPS = (long) Math.Round(stats.Total / stats.TotalSeconds, 2);

      if (superStats == null)
      {
        stats.SDPS = (long) Math.Round(stats.Total / raidTotals.TotalSeconds, 2);
      }
      else
      {
        if (superStats.Total > 0)
        {
          stats.Percent = Math.Round(Convert.ToDouble(stats.Total) / superStats.Total * 100, 2);
        }

        stats.SDPS = (long) Math.Round(stats.Total / superStats.TotalSeconds, 2);

        if (resistCounts != null && superStats.Name == DataManager.Instance.PlayerName)
        {
          uint value;
          if (resistCounts.TryGetValue(stats.Name, out value))
          {
            stats.Resists = value;
            stats.ResistRate = stats.LuckRate = Math.Round(Convert.ToDouble(stats.Resists) / (stats.Hits + stats.Resists) * 100, 2);
          }
        }
      }

      // handle sub stats
      var playerStats = stats as PlayerStats;

      if (playerStats != null)
      {
        Parallel.ForEach(playerStats.SubStats.Values, subStats => UpdateCalculations(subStats, raidTotals, resistCounts, playerStats));

        // optional stats
        if (playerStats.SubStats2 != null)
        {
          Parallel.ForEach(playerStats.SubStats2.Values, subStats => UpdateCalculations(subStats, raidTotals, resistCounts, playerStats));
        }
      }
    }

    internal static ConcurrentDictionary<string, uint> GetPlayerDeaths(PlayerStats raidStats)
    {
      Dictionary<string, uint> deathCounts = new Dictionary<string, uint>();

      if (raidStats.BeginTimes.Count > 0 && raidStats.LastTimes.Count > 0)
      {
        double beginTime = raidStats.BeginTimes.First();
        double endTime = raidStats.LastTimes.Last() + DEATH_TIME_OFFSET;

        Parallel.ForEach(DataManager.Instance.GetPlayerDeathsDuring(beginTime, endTime), block =>
        {
          block.Actions.ForEach(action =>
          {
            PlayerDeath death = action as PlayerDeath;
            Helpers.StringUIntAddHelper.Add(deathCounts, death.Player, 1);
          });
        });
      }

      return new ConcurrentDictionary<string, uint>(deathCounts);
    }
  }

  internal class Parse
  {
    internal string Name { get; set; }
    internal CombinedDamageStats Combined { get; set; }
    internal List<PlayerStats> Selected { get; set; }
    internal virtual StatsSummary Create(bool showTotals, bool rankPlayers)
    {
      return null;
    }
  }
}