using AIOne.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace AIOne
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
      return SplitWords(phrase).Count;
    }

    public static int CountWordsFromDictionary(Dictionary<string, int> dico)
    {
      return dico.Sum(word => word.Value);
    }

    public static string[] SplitWordsUsingRegex(string sentence)
    {
      return Regex.Split(sentence, @"\W+");
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
        cleanedWord = Regex.Replace(cleanedWord, @"\d", string.Empty);

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

    public static string RemoveEndPunctuation(string phrase)
    {
      return phrase.TrimEnd(',').TrimEnd('.').TrimEnd(';').TrimEnd(':');
    }

    public static void InitStartFiles()
    {
      foreach (string language in Settings.Default.ListOfLanguages.Split(','))
      {
        switch (language.ToLower().Trim())
        {
          case "french":
            if (!File.Exists(Settings.Default.FrenchFileName))
            {
              // create french basic file if not exist
              CreateFile(Settings.Default.FrenchFileName, "french");

              // AddWordsToFile(Settings.Default.FrenchFileName, GetBasicWords(Settings.Default.FrenchFileName));
            }
            break;

          case "english":
            if (!File.Exists(Settings.Default.EnglishFileName))
            {
              // create English basic file if not exist
              CreateFile(Settings.Default.EnglishFileName, "english");

              // AddWordsToFile(Settings.Default.EnglishFileName, GetBasicWords(Settings.Default.EnglishFileName));
            }
            break;
        }
      }
    }

    public static void CreateFile(string fileName, string language)
    {
      try
      {
        var words = GetBasicWords(language).Split(',');
        using (StreamWriter sw = new StreamWriter(fileName))
        {
          foreach (string word in words)
          {
            sw.WriteLine(word.Trim());
          }
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
      switch (language)
      {
        case "french":
          result = "je,tu,il,elle,nous,vous,ils,elles,le,la,là,de,et,dans,est,pour,sur,ce,depuis,avoir,être,nouveau,plus,un,une,sera,maison,peut,si,page,mon,man,chercher,avait,libre,mais,ou,où,donc,or,ni,car,autre,autres,non,information,informations,temps,site,haut,que,quoi,quel,quels,quelle,quelles,leur,nouvelles,voir,seulement,quand,contact,ici,web,aussi,maintenant,aider,obtenir,été,comment,serait,service,services,des,sa,son,ses,trouver";
          break;

        case "english":
          result = "the,and,of,to,in,it,his,you,was,he,that,is,my,with,as,at,have,be,which,not,had,for,she,but,me,from,there,said,this,your,up,then,on,do,who,are,will,one,by,what,her,all,into,an,were,has,or,man,so,if,down,upon,been,when,very,could,we,out,am,may,him,own,would,some,must,how,street,see,know,before,should,most,little,now,just,no,house,minutes,other,eyes,our,indeed,two,matter,they,such,more,yet,door,looked,good,quite,majesty,three,case,think,half,only,face,nothing,once,five,found,lodge,front,heard,under,mind,seen,might,than,while,every,still,time,their,part,fire,over,remarked,too,where,gentleman,myself,well,note,without,paper,window,come,understand,about,them,shall,church,name,himself,doubt,us,soul,however,knew,friend,again,twice,room,work,seven,tell,much,came,long,left,right,address,o'clock,visitor,mask,small,make,asked,rather,its,made,hand,whom,back,none,say,person,king,men,take,throw,nature,baker,those,these,returned,dark,armchair,answered,six,side,give,clear,times,interested,enough,open,importance";
          break;
        case "spanish": // see http://www.gutenberg.org/cache/epub/15353/pg15353.txt
          result = "de,en,est,no,puedo,tu,eres,yo,contigo,mio,ir,la,playa,presidenta,si,comprendo,bien,nuestra,colega,afirma,ella,que,este,tan,largo,texto,ha,sido,presentado,como,una,enmienda,oral,el,que,los,se,qué,un,las,es,no,al,del,su,una,pres,con,por,más,qué,son,para,me,pero,tiene,le,dijo,muy,the,lo,mi,past,cómo,cuando,está,hay,había,como,era,sus,in,be,abs,dónde,días,por,esta,canal,todos,él,después,señor,dos,ciudad,tío,casa,fué,subj,este,parte,yo,padre,hombre,tres,zapatos,quién,uno,ellos,dinero,día,cuál,cada,ya,mujer,cuatro,todas,hace,he,mayor,mil,vez,entonces,hizo,clase,tamburí,ella,otro,esto,si,estaba,as,portero,ha,mucho,tiempo,cielo,españa,año,tan,también,porque,todo,gran,cinco,oro,estados,el,tu,cuándo,paciencia,at,están,madre,sin,cuántos,donde,hacer,cuáles,sala,unidos,hermanos,mesa,población,años,sobre,escuela,maestro,país,sombrero,vaca,veces,puerta,tengo,llama,tenía,respondió,cabra,cuánto,tierra,partes,noche,poco,éste,it,part,discípulo,monedas,meses,invierno,grande,va,américa,esa,adónde,estudiante,muchos,rey,diez,allí,nieve,ni,ojos,jornalero,eso,te,decir,preguntó,sí,marido,posadero,perro,espejo,discípulos,bien,gente,hacen,hombres,vino,mundo,fueron,tanto,come,de,primavera,cuerpo,criado,mañana,hasta,otros,piso,nunca,durante,otra,casi,princesa,amigo,zapatero,aquí,por,verano,méjico,brasil,algunos,suelo,tienen,siempre,llaman,millones,mis,señora,veinte,pesetas,largo,les,animal,pues,lugareño,marqués,órganos,nuestra,juan,nada,pizarra,antes,hijos,unos,flores,mejor,allá,pobre,llegó,haber,desde,amigos,camino,huéspeda,niña,order,spain,pron,by,pobres,cuba,nacional,soy,algunas,sólo,ahora,palabra,cerca,cincuenta,vale,puede,entre,tabaco,dijeron,sido,fin,ser,puso,ver,fue,hay,es,cuántas,describa,no,ser,dura,muchacho,barbero,estoy,cabeza,sur,ocho,han,plata,sesenta,tal,sino,encuentran,región,buen,principal,favor,mientras,hecho,dió,estas,quien,iguales,have,en,up,adv,que,look,little,haber,lección,palabras,amo,banco,frío,doce,norte,manera,hijo,valor,mismo,estos,viene,agua,boca,manos,toda,illustration,momento,efecto,habían,buena,estaban,barón,fonda,contento,joven,mí,eran,mamerto,spanish,about,place,al,familia,estreno,chile,ventrílocuo,peral,huevos,aquel,muchas,grandes,bajo,maestro,felipe,seis,hija,cobre,color,frente,mano,noches,primero,principales,cara,voz,azúcar,habitantes,teatros,nuevo,madrid,éxito,oír,tú,has,panaderos,paje,diciendo,parece,quién,macario,rubia,an,tener,ochocientos,español,ópera,suerte,inteligente,argentina,tonto,gustan,ana,habla,bueno,presidente,vive,misma,hermana,moneda,cien,trescientos,julio,treinta,siete,piedra,tarde,hielo,hermosa,árboles,cosecha,visto,estado,ganado,importante,república,kilómetros,gracias,ricos,ciudades,siguiente,función,segundo,caballo,río,nos,contestó,verdad,mas,tuvo,algo,tener,isla,mía,ir,forastero,aprendiz,dueño,hicieron,dolores,vió,cadí,hace,poner,tener,setenta,otoño,sastres,portería,voy,domingo,blanco,paredes,aire,tenemos,hoy,todavía,la,menor,muchachos,comer,níquel,quinientos,peseta,dios,gusto,guerra,aún,estómago,pies,con,clima,tierras,obtener,exportaciones,instante,vida,comercio,establo,salió,unas,pregunta,grulla,obispo,carne,buques,cabo,terrible,ardilla,dragón,cuchillo,ayudante,feria,pasó,quiere,pueblo,vivía,hacía,toros";
          break;
        case "german":
          result = "ich";
          break;
        case "latin": // just for the fun of it :O)
          result = "errare,humanum,est,perseverare,diabolicum,ac,accumsan,ad,adipiscing,aenean,aliquam,aliquet,amet,ante,aptent,arcu,at,auctor,augue,bibendum,blandit,commodo,condimentum,congue,consectetur,consequat,conubia,convallis,cras,cubilia,curabitur,curae,cursus,dapibus,diam,dictum,dictumst,dignissim,dis,dolor,donec,dui,duis,efficitur,egestas,eget,eleifend,elementum,elit,enim,erat,eros,est,et,etiam,eu,euismod,ex,facilisi,facilisis,fames,faucibus,felis,fermentum,feugiat,finibus,fringilla,fusce,gravida,habitant,habitasse,hac,hendrerit,himenaeos,iaculis,id,imperdiet,in,inceptos,interdum,justo,lacinia,lacus,laoreet,lectus,leo,libero,ligula,litora,lobortis,luctus,maecenas,magna,magnis,malesuada,massa,mattis,mauris,maximus,metus,mi,molestie,mollis,montes,morbi,mus,nam,nascetur,natoque,nec,neque,netus,nibh,nisi,nisl,non,nostra,nulla,nullam,nunc,odio,orci,ornare,parturient,pellentesque,penatibus,per,pharetra,phasellus,placerat,platea,porta,porttitor,posuere,potenti,praesent,pretium,primis,proin,pulvinar,purus,quam,quis,quisque,rhoncus,ridiculus,risus,rutrum,sagittis,sapien,scelerisque,sed,sem,semper,senectus,sit,sociosqu,sodales,sollicitudin,suscipit,suspendisse,taciti,tellus,tempor,tempus,tincidunt,torquent,tortor,tristique,turpis,ullamcorper,ultrices,ultricies,urna,us,ut,vari,varius,vehicula,vel,velit,venenatis,estibulum,vitae,vivamus,viverra,volutpat,vulputate";
          break;
        default:
          result = "the,of,and,to,a,in,for,is,on,that,by,this,with,i,you,it,not,or,be,are,from,at,as,your,all,have,new,more,an,was,we,will,home,can,us,about,if,page,my,has,search,free,but,our,one,other,do,no,information,time,they,site,he,up,may,what,which,their,news,out,use,any,there,see,only,so,his,when,contact,here,business,who,web,also,now,help,get,pm,view,first,am,been,would,how,were,me,services,some,these,its,like,service,than,find";
          break;
      }
      return result;
    }

    public static string[] GetListOfLanguages()
    {
      return Settings.Default.ListOfLanguages.ToLower().Split(',');
    }

    public static void AddWordsToFile(string fileName, string words)
    {
      try
      {
        using (StreamWriter sw = new StreamWriter(fileName))
        {
          foreach (string word in words.Split(','))
          {
            sw.WriteLine(word.Trim());
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
        string fileName = $"{language.Trim()}.txt";
        if (!File.Exists(fileName))
        {
          InitStartFiles();
        }
      }




      return result;
    }

    public static double PercentageOfWordsFound(Dictionary<string, int> listOfWords)
    {
      // number of words found divided by total number of words equals percentage of words found
      double result = 0.00;

      // init dictionaries
      var listOfLanguagesAvailable = Settings.Default.ListOfLanguages.Split(',').ToList();

      // for each language calculate the number of words found
      Dictionary<string, double> wordsFound = listOfLanguagesAvailable.ToDictionary(language => language, language => 0.0);

      foreach (string language in listOfLanguagesAvailable)
      {
        //
      }

      return result;
    }

    public static double CountFoundWords(List<string> referenceLanguageWords, List<string> listOfWordsToBeDetected)
    {
      double result = 0.0;
      int numberOfWordsFound = 0;
      foreach (var wordKeyPair in listOfWordsToBeDetected)
      {
        if (referenceLanguageWords.Contains(wordKeyPair.ToLower()))
        {
          numberOfWordsFound++;
        }
      }

      if (referenceLanguageWords.Count != 0 && numberOfWordsFound != 0)
      {
        result = numberOfWordsFound / (double)referenceLanguageWords.Count;
      }

      return result;
    }

    public static double CountFoundWordsWithDictionary(List<string> referenceLanguageWords, Dictionary<string, int> listOfWordsToBeDetected)
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
        result = numberOfWordsFound / (double)referenceLanguageWords.Count;
      }

      return result;
    }

    /// <summary>Remove the digits from a string.</summary>
    /// <param name="theString">The string to be analyzed.</param>
    /// <returns>The string sent without any digit.</returns>
    public static string RemoveDigits(string theString)
    {
      return Regex.Replace(theString, @"\d", string.Empty);
    }

    /// <summary>Intention of a sentence.</summary>
    /// <param name="sentence">The sentence to be analyzed.</param>
    /// <returns>An AiEnumerations intention.</returns>
    public static AiEnumerations.Intention IntentOfSentence(string sentence)
    {
      var listOfQuestionStartWords = new List<string>();
      listOfQuestionStartWords.AddRange(Settings.Default.EnglishQuestionStartingWords.Split(','));
      if (listOfQuestionStartWords.Count == 0)
      {
        return AiEnumerations.Intention.Affirmative;
      }

      if (listOfQuestionStartWords.Any(word => sentence.ToLower().StartsWith(word.ToLower().Trim())))
      {
        return AiEnumerations.Intention.Question;
      }

      if (sentence.TrimEnd().EndsWith("?"))
      {
        return AiEnumerations.Intention.Question;
      }

      return AiEnumerations.Intention.Affirmative;
    }

    /// <summary>Computes a percentage of language detection.</summary>
    /// <param name="sentences">One or many sentences to be language detected.</param>
    /// <returns>A dictionary of language and their accuracy as a double.</returns>
    public static Dictionary<string, double> GetLanguageDetectionPercentage(string sentences)
    {
      Dictionary<string, double> result = new Dictionary<string, double>();
      foreach (string language in Settings.Default.ListOfLanguages.Split(','))
      {
        result.Add(language, 0.0);
      }

      // TODO add code

      return result;
    }

    /// <summary>The French tone levels by value</summary>
    /// <returns>A dictionary of French tone levels by value</returns>
    public static Dictionary<double, string> GetFrToneLevelByValue()
    {
      return new Dictionary<double, string>
               {
                 {40.0, AiEnumerations.ToneLevelFr.SereniteDeLEtre.ToString().ToLower() },
                 {30.0, AiEnumerations.ToneLevelFr.Postulats.ToString().ToLower() },
                 {22.0, AiEnumerations.ToneLevelFr.Jeux.ToString().ToLower() },
                 {20.0, AiEnumerations.ToneLevelFr.Action.ToString().ToLower() },
                 {8.0, AiEnumerations.ToneLevelFr.Exultation.ToString().ToLower() },
                 {6.0, AiEnumerations.ToneLevelFr.Esthetique.ToString().ToLower() },
                 {4.0, AiEnumerations.ToneLevelFr.Enthousiasme.ToString().ToLower() },
                 {3.5, AiEnumerations.ToneLevelFr.Gaiete.ToString().ToLower() },
                 {3.3, AiEnumerations.ToneLevelFr.VifInteret.ToString().ToLower() },
                 {3.0, AiEnumerations.ToneLevelFr.Conservatisme.ToString().ToLower() },
                 {2.9, AiEnumerations.ToneLevelFr.InteretModere.ToString().ToLower() },
                 {2.8, AiEnumerations.ToneLevelFr.Satisfait.ToString().ToLower() },
                 {2.6, AiEnumerations.ToneLevelFr.Desinteret.ToString().ToLower() },
                 {2.5, AiEnumerations.ToneLevelFr.Ennui.ToString().ToLower() },
                 {2.4, AiEnumerations.ToneLevelFr.Monotonie.ToString().ToLower() },
                 {2.0, AiEnumerations.ToneLevelFr.Antagonisme.ToString().ToLower() },
                 {1.9, AiEnumerations.ToneLevelFr.Hostilite.ToString().ToLower() },
                 {1.8, AiEnumerations.ToneLevelFr.Douleur.ToString().ToLower() },
                 {1.5, AiEnumerations.ToneLevelFr.Colere.ToString().ToLower() },
                 {1.4, AiEnumerations.ToneLevelFr.Haine.ToString().ToLower() },
                 {1.3, AiEnumerations.ToneLevelFr.Ressentiment.ToString().ToLower() },
                 {1.2, AiEnumerations.ToneLevelFr.PasDeCompassion.ToString().ToLower() },
                 {1.15, AiEnumerations.ToneLevelFr.RessentimentInexprime.ToString().ToLower() },
                 {1.1, AiEnumerations.ToneLevelFr.HostiliteCachee.ToString().ToLower() },
                 {1.02, AiEnumerations.ToneLevelFr.Anxiete.ToString().ToLower() },
                 {1.0, AiEnumerations.ToneLevelFr.Peur.ToString().ToLower() },
                 {0.98, AiEnumerations.ToneLevelFr.Desespoir.ToString().ToLower() },
                 {0.96, AiEnumerations.ToneLevelFr.Terreur.ToString().ToLower() },
                 {0.94, AiEnumerations.ToneLevelFr.Torpeur.ToString().ToLower() },
                 {0.9, AiEnumerations.ToneLevelFr.Compassion.ToString().ToLower() },
                 {0.8, AiEnumerations.ToneLevelFr.Propitiation.ToString().ToLower() },
                 {0.5, AiEnumerations.ToneLevelFr.Chagrin.ToString().ToLower() },
                 {0.375, AiEnumerations.ToneLevelFr.SeRacheter.ToString().ToLower() },
                 {0.3, AiEnumerations.ToneLevelFr.Indigne.ToString().ToLower() },
                 {0.2, AiEnumerations.ToneLevelFr.AvilissementDeSoi.ToString().ToLower() },
                 {0.1, AiEnumerations.ToneLevelFr.Victime.ToString().ToLower() },
                 {0.07, AiEnumerations.ToneLevelFr.SansEspoir.ToString().ToLower() },
                 {0.05, AiEnumerations.ToneLevelFr.Apathie.ToString().ToLower() },
                 {0.03, AiEnumerations.ToneLevelFr.Inutile.ToString().ToLower() },
                 {0.01, AiEnumerations.ToneLevelFr.Mourant.ToString().ToLower() },
                 {0.0, AiEnumerations.ToneLevelFr.MortDuCorps.ToString().ToLower() }
               };
    }

    /// <summary>The French tone levels by name</summary>
    /// <returns>A dictionary of French tone levels by name</returns>
    public static Dictionary<string, double> GetFrToneLevelByName()
    {
      return new Dictionary<string, double>
      {
        {AiEnumerations.ToneLevelFr.SereniteDeLEtre.ToString().ToLower(),40.0},
        {AiEnumerations.ToneLevelFr.Postulats.ToString().ToLower(),30.0},
        {AiEnumerations.ToneLevelFr.Jeux.ToString().ToLower(),22.0},
        {AiEnumerations.ToneLevelFr.Action.ToString().ToLower(),20.0},
        {AiEnumerations.ToneLevelFr.Exultation.ToString().ToLower(),8.0},
        {AiEnumerations.ToneLevelFr.Esthetique.ToString().ToLower(),6.0},
        {AiEnumerations.ToneLevelFr.Enthousiasme.ToString().ToLower(),4.0},
        {AiEnumerations.ToneLevelFr.Gaiete.ToString().ToLower(),3.5},
        {AiEnumerations.ToneLevelFr.VifInteret.ToString().ToLower(),3.3},
        {AiEnumerations.ToneLevelFr.Conservatisme.ToString().ToLower(),3.0},
        {AiEnumerations.ToneLevelFr.InteretModere.ToString().ToLower(),2.9},
        {AiEnumerations.ToneLevelFr.Satisfait.ToString().ToLower(),2.8},
        {AiEnumerations.ToneLevelFr.Desinteret.ToString().ToLower(),2.6},
        {AiEnumerations.ToneLevelFr.Ennui.ToString().ToLower(),2.5},
        {AiEnumerations.ToneLevelFr.Monotonie.ToString().ToLower(),2.4},
        {AiEnumerations.ToneLevelFr.Antagonisme.ToString().ToLower(),2.0},
        {AiEnumerations.ToneLevelFr.Hostilite.ToString().ToLower(),1.9},
        {AiEnumerations.ToneLevelFr.Douleur.ToString().ToLower(),1.8},
        {AiEnumerations.ToneLevelFr.Colere.ToString().ToLower(),1.5},
        {AiEnumerations.ToneLevelFr.Haine.ToString().ToLower(),1.4},
        {AiEnumerations.ToneLevelFr.Ressentiment.ToString().ToLower(),1.3},
        {AiEnumerations.ToneLevelFr.PasDeCompassion.ToString().ToLower(),1.2},
        {AiEnumerations.ToneLevelFr.RessentimentInexprime.ToString().ToLower(),1.15},
        {AiEnumerations.ToneLevelFr.HostiliteCachee.ToString().ToLower(),1.1},
        {AiEnumerations.ToneLevelFr.Anxiete.ToString().ToLower(),1.02},
        {AiEnumerations.ToneLevelFr.Peur.ToString().ToLower(),1.0},
        {AiEnumerations.ToneLevelFr.Desespoir.ToString().ToLower(),0.98},
        {AiEnumerations.ToneLevelFr.Terreur.ToString().ToLower(),0.96},
        {AiEnumerations.ToneLevelFr.Torpeur.ToString().ToLower(),0.94},
        {AiEnumerations.ToneLevelFr.Compassion.ToString().ToLower(),0.9},
        {AiEnumerations.ToneLevelFr.Propitiation.ToString().ToLower(),0.8},
        {AiEnumerations.ToneLevelFr.Chagrin.ToString().ToLower(),0.5},
        {AiEnumerations.ToneLevelFr.SeRacheter.ToString().ToLower(),0.375},
        {AiEnumerations.ToneLevelFr.Indigne.ToString().ToLower(),0.3},
        {AiEnumerations.ToneLevelFr.AvilissementDeSoi.ToString().ToLower(),0.2},
        {AiEnumerations.ToneLevelFr.Victime.ToString().ToLower(),0.1},
        {AiEnumerations.ToneLevelFr.SansEspoir.ToString().ToLower(),0.07},
        {AiEnumerations.ToneLevelFr.Apathie.ToString().ToLower(),0.05},
        {AiEnumerations.ToneLevelFr.Inutile.ToString().ToLower(),0.03},
        {AiEnumerations.ToneLevelFr.Mourant.ToString().ToLower(),0.01},
        {AiEnumerations.ToneLevelFr.MortDuCorps.ToString().ToLower(),0.0}
      };
    }

    /// <summary>The English tone levels by value</summary>
    /// <returns>A dictionary of English tone levels by value</returns>
    public static Dictionary<double, string> GetEnToneLevelByValue()
    {
      return new Dictionary<double, string>
      {
        {40.0, AiEnumerations.ToneLevelEn.SerenityOfBeingness.ToString().ToLower() },
        {30.0, AiEnumerations.ToneLevelEn.Postulates.ToString().ToLower() },
        {22.0, AiEnumerations.ToneLevelEn.Games.ToString().ToLower() },
        {20.0, AiEnumerations.ToneLevelEn.Action.ToString().ToLower() },
        {8.0, AiEnumerations.ToneLevelEn.Exhilaration.ToString().ToLower() },
        {6.0, AiEnumerations.ToneLevelEn.Aesthetic.ToString().ToLower() },
        {4.0, AiEnumerations.ToneLevelEn.Enthusiasm.ToString().ToLower() },
        {3.5, AiEnumerations.ToneLevelEn.Cheerfulness.ToString().ToLower() },
        {3.3, AiEnumerations.ToneLevelEn.StrongInterest.ToString().ToLower() },
        {3.0, AiEnumerations.ToneLevelEn.Conservatism.ToString().ToLower() },
        {2.9, AiEnumerations.ToneLevelEn.MildInterest.ToString().ToLower() },
        {2.8, AiEnumerations.ToneLevelEn.Contented.ToString().ToLower() },
        {2.6, AiEnumerations.ToneLevelEn.Disinterested.ToString().ToLower() },
        {2.5, AiEnumerations.ToneLevelEn.Boredom.ToString().ToLower() },
        {2.4, AiEnumerations.ToneLevelEn.Monotony.ToString().ToLower() },
        {2.0, AiEnumerations.ToneLevelEn.Antagonism.ToString().ToLower() },
        {1.9, AiEnumerations.ToneLevelEn.Hostility.ToString().ToLower() },
        {1.8, AiEnumerations.ToneLevelEn.Pain.ToString().ToLower() },
        {1.5, AiEnumerations.ToneLevelEn.Anger.ToString().ToLower() },
        {1.4, AiEnumerations.ToneLevelEn.Hate.ToString().ToLower() },
        {1.3, AiEnumerations.ToneLevelEn.Resentment.ToString().ToLower() },
        {1.2, AiEnumerations.ToneLevelEn.NoSympathy.ToString().ToLower() },
        {1.15, AiEnumerations.ToneLevelEn.UnexpressedResentment.ToString().ToLower() },
        {1.1, AiEnumerations.ToneLevelEn.CovertHostility.ToString().ToLower() },
        {1.02, AiEnumerations.ToneLevelEn.Anxiety.ToString().ToLower() },
        {1.0, AiEnumerations.ToneLevelEn.Fear.ToString().ToLower() },
        {0.98, AiEnumerations.ToneLevelEn.Despair.ToString().ToLower() },
        {0.96, AiEnumerations.ToneLevelEn.Terror.ToString().ToLower() },
        {0.94, AiEnumerations.ToneLevelEn.Numb.ToString().ToLower() },
        {0.9, AiEnumerations.ToneLevelEn.Sympathy.ToString().ToLower() },
        {0.8, AiEnumerations.ToneLevelEn.Propitiation.ToString().ToLower() },
        {0.5, AiEnumerations.ToneLevelEn.Grief.ToString().ToLower() },
        {0.375, AiEnumerations.ToneLevelEn.MakingAmends.ToString().ToLower() },
        {0.3, AiEnumerations.ToneLevelEn.Undeserving.ToString().ToLower() },
        {0.2, AiEnumerations.ToneLevelEn.SelfAbasement.ToString().ToLower() },
        {0.1, AiEnumerations.ToneLevelEn.Victim.ToString().ToLower() },
        {0.07, AiEnumerations.ToneLevelEn.Hopeless.ToString().ToLower() },
        {0.05, AiEnumerations.ToneLevelEn.Apathy.ToString().ToLower() },
        {0.03, AiEnumerations.ToneLevelEn.Useless.ToString().ToLower() },
        {0.01, AiEnumerations.ToneLevelEn.Dying.ToString().ToLower() },
        {0.0, AiEnumerations.ToneLevelEn.BodyDeath.ToString().ToLower() }
      };
    }

    /// <summary>The English tone levels by name</summary>
    /// <returns>A dictionary of English tone levels by name</returns>
    public static Dictionary<string, double> GetEnToneLevelByName()
    {
      return new Dictionary<string, double>
      {
        {AiEnumerations.ToneLevelFr.SereniteDeLEtre.ToString().ToLower(),40.0},
        {AiEnumerations.ToneLevelFr.Postulats.ToString().ToLower(),30.0},
        {AiEnumerations.ToneLevelFr.Jeux.ToString().ToLower(),22.0},
        {AiEnumerations.ToneLevelFr.Action.ToString().ToLower(),20.0},
        {AiEnumerations.ToneLevelFr.Exultation.ToString().ToLower(),8.0},
        {AiEnumerations.ToneLevelFr.Esthetique.ToString().ToLower(),6.0},
        {AiEnumerations.ToneLevelFr.Enthousiasme.ToString().ToLower(),4.0},
        {AiEnumerations.ToneLevelFr.Gaiete.ToString().ToLower(),3.5},
        {AiEnumerations.ToneLevelFr.VifInteret.ToString().ToLower(),3.3},
        {AiEnumerations.ToneLevelFr.Conservatisme.ToString().ToLower(),3.0},
        {AiEnumerations.ToneLevelFr.InteretModere.ToString().ToLower(),2.9},
        {AiEnumerations.ToneLevelFr.Satisfait.ToString().ToLower(),2.8},
        {AiEnumerations.ToneLevelFr.Desinteret.ToString().ToLower(),2.6},
        {AiEnumerations.ToneLevelFr.Ennui.ToString().ToLower(),2.5},
        {AiEnumerations.ToneLevelFr.Monotonie.ToString().ToLower(),2.4},
        {AiEnumerations.ToneLevelFr.Antagonisme.ToString().ToLower(),2.0},
        {AiEnumerations.ToneLevelFr.Hostilite.ToString().ToLower(),1.9},
        {AiEnumerations.ToneLevelFr.Douleur.ToString().ToLower(),1.8},
        {AiEnumerations.ToneLevelFr.Colere.ToString().ToLower(),1.5},
        {AiEnumerations.ToneLevelFr.Haine.ToString().ToLower(),1.4},
        {AiEnumerations.ToneLevelFr.Ressentiment.ToString().ToLower(),1.3},
        {AiEnumerations.ToneLevelFr.PasDeCompassion.ToString().ToLower(),1.2},
        {AiEnumerations.ToneLevelFr.RessentimentInexprime.ToString().ToLower(),1.15},
        {AiEnumerations.ToneLevelFr.HostiliteCachee.ToString().ToLower(),1.1},
        {AiEnumerations.ToneLevelFr.Anxiete.ToString().ToLower(),1.02},
        {AiEnumerations.ToneLevelFr.Peur.ToString().ToLower(),1.0},
        {AiEnumerations.ToneLevelFr.Desespoir.ToString().ToLower(),0.98},
        {AiEnumerations.ToneLevelFr.Terreur.ToString().ToLower(),0.96},
        {AiEnumerations.ToneLevelFr.Torpeur.ToString().ToLower(),0.94},
        {AiEnumerations.ToneLevelFr.Compassion.ToString().ToLower(),0.9},
        {AiEnumerations.ToneLevelFr.Propitiation.ToString().ToLower(),0.8},
        {AiEnumerations.ToneLevelFr.Chagrin.ToString().ToLower(),0.5},
        {AiEnumerations.ToneLevelFr.SeRacheter.ToString().ToLower(),0.375},
        {AiEnumerations.ToneLevelFr.Indigne.ToString().ToLower(),0.3},
        {AiEnumerations.ToneLevelFr.AvilissementDeSoi.ToString().ToLower(),0.2},
        {AiEnumerations.ToneLevelFr.Victime.ToString().ToLower(),0.1},
        {AiEnumerations.ToneLevelFr.SansEspoir.ToString().ToLower(),0.07},
        {AiEnumerations.ToneLevelFr.Apathie.ToString().ToLower(),0.05},
        {AiEnumerations.ToneLevelFr.Inutile.ToString().ToLower(),0.03},
        {AiEnumerations.ToneLevelFr.Mourant.ToString().ToLower(),0.01},
        {AiEnumerations.ToneLevelFr.MortDuCorps.ToString().ToLower(),0.0}
      };
    }

    public static bool IsUpTone(AiEnumerations.ToneLevelEn toneLevel)
    {
      bool result = false;
      var toneLevels = GetEnToneLevelByName();
      //if (toneLevels.Where(a => a.Key = toneLevel))
      //{

      //}

      return result;
    }

    public static bool IsUpTone(AiEnumerations.ToneLevelFr toneLevel)
    {
      // TODO ADD CODE
      return true;
    }

    public static bool IsUpTone(double toneLevel)
    {
      // TODO ADD CODE
      return true;
    }

    public static bool IsDownTone(AiEnumerations.ToneLevelEn toneLevel)
    {
      bool result = false;
      var toneLevels = GetEnToneLevelByName();
      //if (toneLevels.Where(a => a.Key = toneLevel))
      //{

      //}

      return result;
    }

    public static bool IsDownTone(AiEnumerations.ToneLevelFr toneLevel)
    {
      // TODO ADD CODE
      return true;
    }

    public static bool IsDownTone(double toneLevel)
    {
      // TODO ADD CODE
      return true;
    }
  }
}
