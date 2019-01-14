namespace AIOne
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

  public enum ToneLevelUS
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
    //from 0 to 4.0
    Enthousiasme,
    Gaiete,
    VifInteret,
    Conservatisme,
    InteretModere,
    Satisfait,
    Desinteret,
    Ennui,
    Monotonie,
    Antagonisme,
    Hostilite,
    Douleur,
    Haine,
    Ressentiment,
    PasDeCompassion,
    RessentimentInexprime,
    HostiliteCachee,
    Anxiete,
    Peur,
    Desespoir,
    Terreur,
    Compassion,
    Propiation,
    Chagrin,
    SeRacheter,
    Indigne,
    AvilissementDeSoi,
    Victime,
    SansExpoir,
    Apathie,
    Inutile,
    Mourant,
    MortDuCorps
  }
}