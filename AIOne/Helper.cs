using System.Collections.Generic;
using System.Linq;

namespace AIOne
{
  public static class Helper
  {
    public static IEnumerable<KeyValuePair<string, int>> SortDicoByValue(Dictionary<string, int> sampleDico)
    {
      return sampleDico.OrderByDescending(key => key.Value);
    }

    public static int CountWords(string phrase)
    {
      var dico = new Dictionary<string, int>();
      foreach (var word in SplitWords(phrase))
      {
        if (dico.ContainsKey(word.Key))
        {
          dico[word.Key]++;
        }
        else
        {
          dico.Add(word.Key, 1);
        }
      }

      return dico.Count;
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

    public static Dictionary<string, int> CreateDictionary(string theText)
    {
      var result = new Dictionary<string, int>();
      var tmpWords = theText.Split(' ');
      foreach (string word in tmpWords)
      {
        if (result.ContainsKey(word))
        {
          result[word]++;
        }
        else
        {
          result.Add(word, 1);
        }
      }

      return result;
    }
  }
}