using System.Collections;
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
              CreateFile(Properties.Settings.Default.FrenchFileName);
              AddWordsToFile(Properties.Settings.Default.FrenchFileName, GetBasicWords(Properties.Settings.Default.FrenchFileName));
            }
            break;

          case "english":
            if (!File.Exists(Properties.Settings.Default.EnglishFileName))
            {
              // create English basic file if not exist
              CreateFile(Properties.Settings.Default.EnglishFileName);
              AddWordsToFile(Properties.Settings.Default.EnglishFileName, GetBasicWords(Properties.Settings.Default.EnglishFileName));
            }
            break;
        }
      }
      
    }

    public static void CreateFile(string fileName)
    {
      try
      {
          using(StreamWriter sw = new StreamWriter(fileName))
          {

          }
      }
      catch (System.Exception)
      {
        // file cannot be created            
      }
    }

    public static string GetBasicWords(string fileName)
    {
      string result = string.Empty;
      string language = fileName.SubString(0, fileName.Count - 4);
      switch (language)
        {
          case "french":
            result = "je,tu,il";
            break;

          case "english":
            result = "the,of,and,to,a,in,for,is,on,that,by,this,with,i,you,it,not,or,be,are,from,at,as,your,all,have,new,more,an,was,we,will,home,can,us,about,if,page,my,has,search,free,but,our,one,other,do,no,information,time,they,site,he,up,may,what,which,their,news,out,use,any,there,see,only,so,his,when,contact,here,business,who,web,also,now,help,get,pm,view,first,am,been,would,how,were,me,services,some,these,its,like,service,than,find";
            break;
        }

        return result;
    }

     public static string AddWordsToFile(string fileName, string words)
     {
       try
      {
          using(StreamWriter sw = new StreamWriter(fileName))
          {
            foreach(string word in words.Split(','))
            {
              sw.WriteLine(word);
            }
          }
      }
      catch (System.Exception)
      {
        // cannot write file
      }
     }
  }
}