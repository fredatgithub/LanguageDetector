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
    Fear = 1,
    Antagonism = 2,
    Conservatism = 3,
    Enthusiam = 4,
    Boredom
  }

  public enum ToneLevelFr
  {
    SereniteDeLEtre,
    Postulats,
    Jeux,
    Action,
    Exultation,
    Esthetique,
    Antagonisme,
    Peur
  }
}