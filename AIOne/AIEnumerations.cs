namespace AIOne
{
  public class AiEnumerations
  {
    public enum Intention
    {
      Unknown = 0,
      Question,
      Affirmative
    }

    public enum ToneAcceptance
    {
      ToneNegative = 1,
      TonePositive = 2,
    }

    public enum ToneLevelUSA
    {
      //from 4.0 to 0.0
      Enthusiam = 4,
      Conservatism = 3,
      Antagonism = 2,
      Fear = 1,
      Boredom
    }

    public enum ToneLevelFr
    {
      //from 4.0 to 0.0
      SereniteDeLEtre
    , Postulats
    , Jeux
    , Action
    , Exultation
    , Esthetique
    , Enthousiasme
    , Gaiete
    , VifInteret
    , Conservatisme
    , InteretModere
    , Satisfait
    , Desinteret
    , Ennui
    , Monotonie
    , Antagonisme
    , Hostilite
    , Douleur
    , Colere
    , Haine
    , Ressentiment
    , PasDeCompassion
    , RessentimentInexprime
    , HostiliteCachee
    , Anxiete
    , Peur
    , Desespoir
    , Terreur
    , Torpeur
    , Compassion
    , Propitiation
    , Chagrin
    , SeRacheter
    , Indigne
    , AvilissementDeSoi
    , Victime
    , SansEspoir
    , Apathie
    , Inutile
    , Mourant
    , MortDuCorps
    }
  }
}