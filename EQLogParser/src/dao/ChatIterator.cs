﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace EQLogParser
{
  class ChatIterator : IEnumerable<ChatType>
  {
    private static readonly ChatType END_RESULT = new ChatType();

    private readonly string Home;
    private readonly string Keyword;
    private readonly string From;

    private ZipArchive CurrentArchive = null;
    private StreamReader CurrentReader = null;
    private Dictionary<string, byte> ValidChannels = null;
    private List<string> Directories;
    private List<string> Months;
    private List<string> Entries;
    private int CurrentDirectory = -1;
    private int CurrentMonth = -1;
    private int CurrentEntry = -1;

    internal ChatIterator(string player, List<string> channels = null, string from = null, string keyword = null)
    {
      Home = DataManager.ARCHIVE_DIR + player;

      if (Directory.Exists(Home))
      {
        var years = Directory.GetDirectories(Home);
        if (years.Length > 0)
        {
          Directories = years.ToList().OrderByDescending(year => year).ToList();
          GetNextYear();
        }
      }

      if (channels != null)
      {
        ValidChannels = new Dictionary<string, byte>();
        channels.ForEach(chan => ValidChannels[chan] = 1);
      }

      Keyword = keyword;
      From = from;
    }

    internal void Close()
    {
      CurrentReader?.Close();
      CurrentArchive?.Dispose();
      CurrentReader = null;
      CurrentArchive = null;
    }

    public IEnumerator<ChatType> GetEnumerator()
    {
      ChatType line;
      while ((line = GetNextChat()) != null)
      {
        yield return line;
      }

      yield break;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }

    private ChatType GetNextChat()
    {
      ChatType result = null;

      if (CurrentArchive == null && CurrentMonth < Months.Count)
      {
        CurrentArchive = GetArchive();
      }
      else if (CurrentArchive == null && CurrentMonth >= Months.Count)
      {
        if (GetNextYear())
        {
          return GetNextChat();
        }
      }

      if (CurrentArchive != null && CurrentReader == null)
      {
        CurrentReader = GetNextReader();
        if (CurrentReader == null)
        {
          CurrentMonth++;
          CurrentArchive?.Dispose();
          CurrentArchive = null;
          return GetNextChat();
        }
      }

      if (CurrentReader != null)
      {
        result = END_RESULT;
        while (!CurrentReader.EndOfStream && result == END_RESULT)
        {
          var chatType = ChatLineParser.ParseChatType(CurrentReader.ReadLine());
          if (ValidChannels == null || ValidChannels.ContainsKey(chatType.Channel))
          {
            if (From == null || chatType.Sender.Equals(From, StringComparison.OrdinalIgnoreCase))
            {
              if (Keyword != null)
              {
                int afterSender = chatType.AfterSenderIndex >= 0 ? chatType.AfterSenderIndex : 0;
                int foundIndex = chatType.Line.IndexOf(Keyword, afterSender, StringComparison.OrdinalIgnoreCase);
                if (foundIndex > -1)
                {
                  result = chatType;
                  chatType.KeywordStart = foundIndex;
                }
              }
              else
              {
                result = chatType;
              }
            }
          }
        }

        if (result == END_RESULT)
        {
          CurrentReader.Close();
          CurrentReader = null;
          return GetNextChat();
        }
      }

      return result;
    }

    private bool GetNextYear()
    {
      bool success = false;

      CurrentDirectory++;
      CurrentMonth = -1;

      if (CurrentDirectory < Directories.Count && Directory.Exists(Directories[CurrentDirectory]))
      {
        var months = Directory.GetFiles(Directories[CurrentDirectory]);
        if (months.Length > 0)
        {
          Months = months.ToList().OrderByDescending(month => month).ToList();
          CurrentMonth = 0;
          success = true;
        }
        else
        {
          return GetNextYear();
        }
      }

      return success;
    }

    private StreamReader GetNextReader()
    {
      StreamReader result = null;

      CurrentEntry++;
      if (CurrentEntry < Entries.Count)
      {
        result = new StreamReader(CurrentArchive.GetEntry(Entries[CurrentEntry]).Open());
      }

      return result;
    }

    private ZipArchive GetArchive()
    {
      ZipArchive result = null;

      if (CurrentDirectory > -1 && CurrentDirectory < Directories.Count && CurrentMonth > -1 && CurrentMonth < Months.Count)
      {
        result = ZipFile.OpenRead(Months[CurrentMonth]);
        Entries = result.Entries.Where(entry => entry.Name != ChatManager.INDEX).OrderByDescending(entry => entry.Name).Select(entry => entry.Name).ToList();
        CurrentEntry = -1;
      }

      return result;
    }
  }
}
