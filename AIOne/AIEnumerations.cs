namespace AIOne
{
  using System;

  public static class AiEnumerations
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

    [Flags]
    public enum ToneLevelEn
    {
      // From 0.0 to 40.0 not in order
      BodyDeath = 0,
      Fear = 1,
      Antagonism = 2,
      Conservatism = 3,
      Enthusiasm = 4,
      Cheerfulness,
      Aesthetic = 6,
      StrongInterest,
      Exhilaration = 8,
      MildInterest,
      Contented,
      Disinterested,
      Boredom,
      Monotony,
      Hostility,
      Pain,
      Anger,
      Hate,
      Resentment,
      NoSympathy,
      Action = 20,
      UnexpressedResentment,
      Games = 22,
      CovertHostility,
      Anxiety,
      Despair,
      Terror,
      Numb,
      Sympathy,
      Propitiation,
      Postulates = 30,
      Grief,
      MakingAmends,
      Undeserving,
      SelfAbasement,
      Victim,
      Hopeless,
      Apathy,
      Useless,
      Dying,
      SerenityOfBeingness = 40,
    }

    [Flags]
    public enum ToneLevelFr
    {
      // From 0.0 to 40.0 not in order
      MortDuCorps = 0,
      Peur = 1,
      Antagonisme = 2,
      Conservatisme = 3,
      Enthousiasme = 4,
      Gaiete,
      Esthetique = 6,
      VifInteret,
      Exultation = 8,
      InteretModere,
      Satisfait,
      Desinteret,
      Ennui,
      Monotonie,
      Hostilite,
      Douleur,
      Colere,
      Haine,
      Ressentiment,
      PasDeCompassion,
      Action = 20,
      RessentimentInexprime,
      Jeux = 22,
      HostiliteCachee,
      Anxiete,
      Desespoir,
      Terreur,
      Torpeur,
      Compassion,
      Propitiation,
      Postulats = 30,
      Chagrin,
      SeRacheter,
      Indigne,
      AvilissementDeSoi,
      Victime,
      SansEspoir,
      Apathie,
      Inutile,
      Mourant,
      SereniteDeLEtre = 40,
    }
  }
}