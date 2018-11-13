﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AIOne
{
  // ReSharper disable once InconsistentNaming
  public static class AIHelper
  {
    public static IEnumerable<KeyValuePair<string, int>> SortDicoByValue(Dictionary<string, int> sampleDico)
    {
      return sampleDico.OrderByDescending(sortingBy => sortingBy.Value);
    }

    public static IEnumerable<KeyValuePair<string, int>> SortDicoByKey(Dictionary<string, int> sampleDico)
    {
      return sampleDico.OrderByDescending(sortingBy => sortingBy.Key);
    }

    public static int CountWords(string phrase)
    {
      var dico = new Dictionary<string, int>();
      dico = SplitWords(phrase);
      return dico.Count;
    }

    public static Dictionary<string, int> SplitLetters(string phrase)
    {
      var dico = new Dictionary<string, int>();
      foreach (var word in phrase)
      {
        if (dico.ContainsKey(word.ToString()))
        {
          dico[word.ToString()]++;
        }
        else
        {
          dico.Add(word.ToString(), 1);
        }
      }

      return dico;
    }

    public static Dictionary<string, int> SplitWords(string phrase)
    {
      var listOfWords = phrase.Split(' ');
      var dico = new Dictionary<string, int>();
      foreach (string word in listOfWords)
      {
        if (word.Trim() == string.Empty)
        {
          continue;
        }

        if (dico.ContainsKey(word))
        {
          dico[word]++;
        }
        else
        {
          dico.Add(word, 1);
        }
      }

      return dico;
    }

    public static Dictionary<string, int> SplitWordsTopTen(string phrase, int topTen = 10)
    {
      var dico = new Dictionary<string, int>();
      dico = SplitWords(phrase);
      dico = (Dictionary<string, int>)SortDicoByValue(dico);
      IEnumerable<KeyValuePair<string, int>> result = dico.Take(topTen);
      return (Dictionary<string, int>)result;
    }

    public static Dictionary<string, int> RemoveDictionaryTail(Dictionary<string, int> dico, int tailValue = 1)
    {
      var result = new Dictionary<string, int>();
      result = (Dictionary<string, int>)dico.Take(tailValue); 
      return result;
    }

    public static string RemovePunctuation(string phrase)
    {
      return phrase.Replace(",", "").Replace(".", "").Replace(";", "").Replace(":", "");
    }

    public static void InitStartFiles()
    {
      foreach (string language in Properties.Settings.Default.ListOfLanguages.Split(','))
      {
        switch (language)
        {
          case "french":
            if (!File.Exists(Properties.Settings.Default.FrenchFileName))
            {
              // create french basic file if not exist

            }
            break;

          case "english":
            if (!File.Exists(Properties.Settings.Default.EnglishFileName))
            {
              // create English basic file if not exist

            }
            break;

        }
      }
      
    }
  }
}