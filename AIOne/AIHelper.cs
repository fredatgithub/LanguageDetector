﻿using AIOne.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace AIOne
{
  /// <summary>AI helper class</summary>
  // ReSharper disable once InconsistentNaming
  public static class AIHelper
  {
    /// <summary>Sort a dictionary by value.</summary>
    /// <param name="sampleDico"></param>
    /// <returns>A dictionary sorted by value.</returns>
    public static IEnumerable<KeyValuePair<string, int>> SortDicoByValue(Dictionary<string, int> sampleDico)
    {
      return sampleDico.OrderByDescending(sortingBy => sortingBy.Value);
    }

    /// <summary>Sort a dictionary by key.</summary>
    /// <param name="sampleDico"></param>
    /// <returns>A dictionary sorted by key.</returns>
    public static IEnumerable<KeyValuePair<string, int>> SortDicoByKey(Dictionary<string, int> sampleDico)
    {
      return sampleDico.OrderByDescending(sortingBy => sortingBy.Key);
    }

    /// <summary>Count the number of words from a phrase.</summary>
    /// <param name="phrase">The phrase to count words.</param>
    /// <returns>The numner of words.</returns>
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

        // exclude word with length equals to 1
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

    public static IEnumerable<string> GetWordsDistinct(string[] words)
    {
      List<string> result = new List<string>();
      for (int i = 0; i < words.Length; i++)
      {
        if (!result.Contains(words[i].ToLower()))
        {
          result.Add(words[i].ToLower());
        }
      }

      return result;
    }

    public static string RemoveWrongCharacters(string sentence)
    {
      sentence = Regex.Replace(sentence, @"[\d-]", string.Empty); // remove numbers
      sentence = sentence.Replace(".", "");
      sentence = sentence.Replace(";", "");
      sentence = sentence.Replace("!", "");
      sentence = sentence.Replace("-", ",");
      sentence = sentence.Replace(" ", ",");
      sentence = sentence.Replace(",,", ",");
      sentence = sentence.Replace(",,", ",");
      sentence = sentence.Replace("/", "");
      sentence = sentence.Replace("\"", "");
      sentence = sentence.Replace("?", "");

      return sentence;
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
      switch (language.ToLower())
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
          result = "alt,auch,bahnhofstraße,beruf,besonders,bin,bruder,computerspiele,denn,der,die,ein,eine,einen,eltern,englisch,er,erst,französisch,fußball,habe,haben,hallo,handy,handynummer,hobbys,ich,in,ist,jahre,königstraße,lehrer,mag,maier,mein,meine,möchte,mutter,nett,nicht,noch,schule,schüler,schwester,schwimmen,sehr,sie,sind,sport,studiert,tierärztin,und,vater,von,werden,wohne,zahnarzt,zahnärztin,zahnarztpraxis,zahnmedizin,ab,aber,abgeschlagen,ablösesummen,achtelfinale,airways,alimentierter,allerdings,alnahjan,als,an,anderen,angeblich,angebliche,anstrengen,anteile,antreten,arabischen,auch,auf,aufgrund,aus,ausgegeben,ausgeglichene,ausgeschlossen,aushelfen,barcelonatrainer,begrenztem,bei,beide,beiden,beim,bekannt,belegt,besonders,bestrafen,beteiligung,betreute,beurteilt,bezahlen,bilanz,bilanzen,bin,bleiben,cas,chalifa,seit, dafür,damalige,damals,das,debatte,dem,den,der,deren,des,dessen,die,diese,diesem,direkt,doch,dreistelliger,durch,dürfen,dürfte,ebenfalls,ehemaligen,ein,eine,einem,einer,einnahmen,einspruch,emirate,empfanden,englische,englischen,enorme,entfallenden,entscheidung,entsprechende,enttäuscht,entwickelt,er,erfolgreiche,erfolgreichsten,erst,ersten,erwarb,es,etihad,euro,europäische,europäischen,europapokalwettbewerben,fairplay,fall,falsche,fc,fehlende,fifachef,financial,financialfairplaysystem,finanzstarken,football,französischen,für,fußball,fußballadel,fußballverband,gefahr,gegeben,gegen,gehälter,geholfen,geld,football,geldstrafe,geldstrafen,geleistet,genau,gewaltenteilung,gewinnausfall,geworden,gianni,gier,gremiums,grenzen,große,grund,guardiola,gündoğan,haben,halbbruder,hat,hatte,hauptanteilseigner,hauptstadtclub,heutige,hinter,höchsten,höhe,ihre,ihren,ihrer,ilkay,im,immer,infantino,informationen,initiiert,insbesondere,internationalen,investoren,investorengelder,ist,jedem,juristisch,kader,kadergröße,katar,kinder,club,kleinen,königsklasse,können,könnten,konsequent,kritik,kritiker,kritisiert,kritisierte,lage,laufenden,läuft,der,legt,leroy,limitiert,liverpool,madrid,manchester,manchmal,mannschaft,mansour,mehr,meister,meisterschaft,milde,milliarde,millionen,millionenhöhe,mit,mitteilung,möglich,muss,müssen,nach,nahen,nationalspieler,nicht,nun,nur,offenbar,osten,paris,pep,platz,präsidenten,pro,prozess,rangiert,reagierte,real,rechnen,mehr,regeln,regelverstöße,regelwerk,reichen,renommierten,saintgermain,saison,saisons,sané,scheich,schnell,schritt,schwerer,schwerwiegende,sehen,sehr,sei,sein,seine,seit,sich,sie,sind,so,sogenannte,soll,sollen,sorgte,spielen,spieler,spielklasse,spielt,spielzeiten,sponsoren,sponsoreneinnahmen,sportgerichtshof,starken,stehen,stellungnahme,strafen,tatsächlich,teilnahme,der,topclub,transferausgaben,transfermarkt,über,überbewertet,überbewertung,übermittelt,überprüft,überrascht,umfang,umgehen,das,unabhängige,und,unter,untersuchung,unzulässige,verein,verein,wegen,vereine,vereinen,vereinigten,verfolgt,vergleich,verhindern,verkauft,veröffentlicht,demnach,versteckt,verstöße,verstößen,verstoßen,infantino,vertuschung,verzerren,viel,viele,vom,von,vor,vorverurteilenden,vorweisen,warfen,website,weit,werde,werden,gianni,wesentlich,wettbewerb,wettbewerbsausschlüsse,wie,wieder,wiegen,will,wohlhabende,worden,wurde,wurden,zahlen,zählen,zahlungen,zayed,zayid,zerfressen,zu,zudem,zum,zusammenhang,zuständigen,zwar,zwei,zweiter,zwischen";
          break;
        case "latin": // just for the fun of it :O)
          result = "errare,humanum,est,perseverare,diabolicum,ac,accumsan,ad,adipiscing,aenean,aliquam,aliquet,amet,ante,aptent,arcu,at,auctor,augue,bibendum,blandit,commodo,condimentum,congue,consectetur,consequat,conubia,convallis,cras,cubilia,curabitur,curae,cursus,dapibus,diam,dictum,dictumst,dignissim,dis,dolor,donec,dui,duis,efficitur,egestas,eget,eleifend,elementum,elit,enim,erat,eros,est,et,etiam,eu,euismod,ex,facilisi,facilisis,fames,faucibus,felis,fermentum,feugiat,finibus,fringilla,fusce,gravida,habitant,habitasse,hac,hendrerit,himenaeos,iaculis,id,imperdiet,in,inceptos,interdum,justo,lacinia,lacus,laoreet,lectus,leo,libero,ligula,litora,lobortis,luctus,maecenas,magna,magnis,malesuada,massa,mattis,mauris,maximus,metus,mi,molestie,mollis,montes,morbi,mus,nam,nascetur,natoque,nec,neque,netus,nibh,nisi,nisl,non,nostra,nulla,nullam,nunc,odio,orci,ornare,parturient,pellentesque,penatibus,per,pharetra,phasellus,placerat,platea,porta,porttitor,posuere,potenti,praesent,pretium,primis,proin,pulvinar,purus,quam,quis,quisque,rhoncus,ridiculus,risus,rutrum,sagittis,sapien,scelerisque,sed,sem,semper,senectus,sit,sociosqu,sodales,sollicitudin,suscipit,suspendisse,taciti,tellus,tempor,tempus,tincidunt,torquent,tortor,tristique,turpis,ullamcorper,ultrices,ultricies,urna,us,ut,vari,varius,vehicula,vel,velit,venenatis,estibulum,vitae,vivamus,viverra,volutpat,vulputate";
          break;
        default:
          result = "the,of,and,to,in,for,is,on,that,by,this,with,you,it,not,or,be,are,from,at,as,your,all,have,new,more,an,was,we,will,home,can,us,about,if,page,my,has,search,free,but,our,one,other,do,no,information,time,they,site,he,up,may,what,which,their,news,out,use,any,there,see,only,so,his,when,contact,here,business,who,web,also,now,help,get,pm,view,first,am,been,would,how,were,me,services,some,these,its,like,service,than,find";
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
  }
}
