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

    public enum ToneLevelEn
    {
      //from 4.0 to 0.0
      SerenityOfBeingness = 40,
      Postulates = 30,
      Games = 22,
      Action = 20,
      Exhilaration = 8,
      Aesthetic = 6,
      Enthusiasm = 4,
      Cheerfulness,
      StrongInterest,
      Conservatism = 3,
      MildInterest,
      Contented,
      Disinterested,
      Boredom,
      Monotony,
      Antagonism = 2,
      Hostility,
      Pain,
      Anger,
      Hate,
      Resentment,
      NoSympathy,
      UnexpressedResentment,
      CovertHostility,
      Anxiety,
      Fear = 1,
      Despair,
      Terror,
      Numb,
      Sympathy,
      Propitiation,
      Grief,
      MakingAmends,
      Undeserving,
      SelfAbasement,
      Victim,
      Hopeless,
      Apathy,
      Useless,
      Dying,
      BodyDeath = 0
    }

    public enum ToneLevelFr
    {
      //from 4.0 to 0.0
      SereniteDeLEtre = 40,
      Postulats = 30,
      Jeux = 22,
      Action = 20,
      Exultation = 8,
      Esthetique = 6,
      Enthousiasme = 4,
      Gaiete,
      VifInteret,
      Conservatisme = 3,
      InteretModere,
      Satisfait,
      Desinteret,
      Ennui,
      Monotonie,
      Antagonisme = 2,
      Hostilite,
      Douleur,
      Colere,
      Haine,
      Ressentiment,
      PasDeCompassion,
      RessentimentInexprime,
      HostiliteCachee,
      Anxiete,
      Peur = 1,
      Desespoir,
      Terreur,
      Torpeur,
      Compassion,
      Propitiation,
      Chagrin,
      SeRacheter,
      Indigne,
      AvilissementDeSoi,
      Victime,
      SansEspoir,
      Apathie,
      Inutile,
      Mourant,
      MortDuCorps = 0
    }
  }
}