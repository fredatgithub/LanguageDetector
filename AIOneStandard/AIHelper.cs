﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using AIOneStandard.Properties;

namespace AIOneStandard
{
  /// <summary>
  /// AI helper class
  /// </summary>
  // ReSharper disable once InconsistentNaming
  public static class AIHelper
  {
    /// <summary>
    /// Sort a dictionary by value.
    /// </summary>
    /// <param name="sampleDico"></param>
    /// <returns>A dictionary sorted by value.</returns>
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

    public static int CountWordsFromDictionary(Dictionary<string, int> dico)
    {
      return dico.Sum(word => word.Value);
    }

    public static Dictionary<string, int> SplitLetters(string phrase) // why this method name?
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

    public static Dictionary<string, int> SplitWords(string phrases)
    {
      var listOfWords = phrases.Split(' ');
      var dico = new Dictionary<string, int>();
      foreach (string word in listOfWords)
      {
        string cleanedWord = word.ToLower().Trim('"').Trim('!').Trim('\'').Trim('(').Trim(')').Trim().Trim('"');
        // no empty string
        if (cleanedWord == string.Empty || cleanedWord == Environment.NewLine)
        {
          continue;
        }

        // no word length equal to 1
        if (cleanedWord.Length == 1)
        {
          continue;
        }

        // if word contains only numbers then continue
        if (cleanedWord.All(char.IsDigit))
        {
          continue;
        }

        // remove numbers in any word
        cleanedWord = Regex.Replace(cleanedWord, @"\d", "");

        if (dico.ContainsKey(cleanedWord))
        {
          dico[cleanedWord]++;
        }
        else
        {
          dico.Add(cleanedWord, 1);
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
      return phrase.Replace(",", " ").Replace(".", " ").Replace(";", " ").Replace(":", " ").Replace("?", " ");
    }

    public static void InitStartFiles()
    {
      foreach (string language in Settings.Default.ListOfLanguages.Split(','))
      {
        switch (language.ToLower())
        {
          case "french":
            if (!File.Exists(Settings.Default.FrenchFileName))
            {
              // create french basic file if not exist
              CreateFile(Settings.Default.FrenchFileName);
              AddWordsToFile(Settings.Default.FrenchFileName, GetBasicWords(Settings.Default.FrenchFileName));
            }
            break;

          case "english":
            if (!File.Exists(Settings.Default.EnglishFileName))
            {
              // create English basic file if not exist
              CreateFile(Settings.Default.EnglishFileName);
              AddWordsToFile(Settings.Default.EnglishFileName, GetBasicWords(Settings.Default.EnglishFileName));
            }
            break;
          default:
            break;
        }
      }
    }

    public static void CreateFile(string fileName)
    {
      try
      {
        using (StreamWriter sw = new StreamWriter(fileName))
        {

        }
      }
      catch (Exception)
      {
        // file cannot be created            
      }
    }

    public static string GetBasicWords(string language)
    {
      string result = string.Empty;
      //string language = fileName.Substring(0, fileName.Length - 4).ToLower();
      switch (language)
      {
        case "french":
          result = "je,tu,il,elle,nous,vous,ils,elles,le,la,là,de,et,a,à,dans,est,pour,sur,ce,depuis,avoir,être,nouveau,plus,un,une,sera,maison,peut,si,page,mon,man,chercher,avait,libre,mais,ou,où,donc,or,ni,car,autre,autres,non,information,informations,temps,site,haut,que,quoi,quel,quels,quelle,quelles,leur,nouvelles,voir,seulement,quand,contact,ici,web,aussi,maintenant,aider,obtenir,été,comment,serait,service,services,des,sa,son,ses,trouver";
          break;

        case "english":
          result = "the,and,of,to,in,it,his,you,was,he,that,is,my,with,as,at,have,be,which,not,had,for,she,but,me,from,there,said,this,your,up,then,on,do,who,are,will,one,by,what,her,all,into,an,were,has,or,man,so,if,down,upon,been,when,very,could,we,out,am,may,him,own,would,some,must,how,street,see,know,before,should,most,little,now,just,no,house,minutes,other,eyes,our,indeed,two,matter,they,such,more,yet,door,looked,good,quite,majesty,three,case,think,half,only,face,nothing,once,five,found,lodge,front,heard,under,mind,seen,might,than,while,every,still,time,their,part,fire,over,remarked,too,where,gentleman,myself,well,note,without,paper,window,come,understand,about,them,shall,church,name,himself,doubt,us,soul,however,knew,friend,again,twice,room,work,seven,tell,much,came,long,left,right,address,o'clock,visitor,mask,small,make,asked,rather,its,made,hand,whom,back,none,say,person,king,men,take,throw,nature,baker,those,these,returned,dark,armchair,answered,six,side,give,clear,times,interested,enough,open,importance";
          break;
        default:
          result = "the,of,and,to,a,in,for,is,on,that,by,this,with,i,you,it,not,or,be,are,from,at,as,your,all,have,new,more,an,was,we,will,home,can,us,about,if,page,my,has,search,free,but,our,one,other,do,no,information,time,they,site,he,up,may,what,which,their,news,out,use,any,there,see,only,so,his,when,contact,here,business,who,web,also,now,help,get,pm,view,first,am,been,would,how,were,me,services,some,these,its,like,service,than,find";
          break;
      }
      return result;
    }

    public static void AddWordsToFile(string fileName, string words)
    {
      try
      {
        using (StreamWriter sw = new StreamWriter(fileName))
        {
          foreach (string word in words.Split(','))
          {
            sw.WriteLine(word);
          }
        }
      }
      catch (Exception)
      {
        // cannot write file
      }
    }

    public static Dictionary<string, int> AddTwoDictionaries(Dictionary<string, int> dico1, Dictionary<string, int> dico2)
    {
      foreach (KeyValuePair<string, int> pair in dico2)
      {
        if (dico1.ContainsKey(pair.Key))
        {
          dico1[pair.Key] = dico1[pair.Key] + pair.Value;
        }
        else
        {
          dico1.Add(pair.Key, pair.Value);
        }
      }

      return dico1;
    }

    public static string[] DetectLanguage(Dictionary<string, int> listOfWordsToBeDetected)
    {
      string[] result = { "not found", "unknown" };
      var languageWordsFound = new Dictionary<string, int>();
      // get a list of languages in xml files
      var listOfLanguagesAvailable = Settings.Default.ListOfLanguages.Split(',').ToList();

      // for each language calculate the number of words found
      foreach (string language in listOfLanguagesAvailable)
      {
        string fileName = $"{language}.txt";
        if (!File.Exists(fileName))
        {
          AddWordsToFile(fileName, GetBasicWords(fileName));
        }
      }




      return result;
    }

    public static double PercentageOfWordsFound(Dictionary<string, int> listOfWords)
    {
      // number of words found divided by total number of words equals percentage of words found
      double result = 0.00;
      Dictionary<string, double> wordsFound = new Dictionary<string, double>();

      // init dictionaries
      var listOfLanguagesAvailable = Settings.Default.ListOfLanguages.Split(',').ToList();
      // for each language calculate the number of words found
      foreach (string language in listOfLanguagesAvailable)
      {
        wordsFound.Add(language, 0.0);
      }



      return result;

    }

    public static double CountFoundWords(List<string> referenceLanguageWords, Dictionary<string, int> listOfWordsToBeDetected)
    {
      double result = 0.0;
      int numberOfWordsFound = 0;
      foreach (var wordKeyPair in listOfWordsToBeDetected)
      {
        if (referenceLanguageWords.Contains(wordKeyPair.Key))
        {
          numberOfWordsFound++;
        }
      }

      if (referenceLanguageWords.Count != 0 && numberOfWordsFound != 0)
      {
        result = (double)numberOfWordsFound / (double)referenceLanguageWords.Count;
      }

      return result;
    }

    public static string RemoveDigits(string theString)
    {
      return Regex.Replace(theString, @"\d", "");
    }
  }
}