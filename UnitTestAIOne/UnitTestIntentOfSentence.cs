using AIOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAIOne
{
  [TestClass]
  public class UnitTestIntentOfSentence
  {
    [TestMethod]
    public void TestMethod_IntentOfSentence_affirmation()
    {
      const string Source = "I have twenty dollars";
      const Intention expected = Intention.Affirmative;
      Intention result = AIHelper.IntentOfSentence(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IntentOfSentence_affirmatio2()
    {
      const string Source = "A long long time ago in a galaxy far far away.";
      const Intention expected = Intention.Affirmative;
      Intention result = AIHelper.IntentOfSentence(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IntentOfSentence_question_do()
    {
      const string Source = "Do you have twenty dollars";
      const Intention expected = Intention.Question;
      Intention result = AIHelper.IntentOfSentence(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IntentOfSentence_question_what()
    {
      const string Source = "What is your name";
      const Intention expected = Intention.Question;
      Intention result = AIHelper.IntentOfSentence(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IntentOfSentence_question_were()
    {
      const string Source = "Were you born in the US";
      const Intention expected = Intention.Question;
      Intention result = AIHelper.IntentOfSentence(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IntentOfSentence_question_how()
    {
      const string Source = "How are you";
      const Intention expected = Intention.Question;
      Intention result = AIHelper.IntentOfSentence(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IntentOfSentence_question_mark()
    {
      const string Source = "you are twenty aren't you?";
      const Intention expected = Intention.Question;
      Intention result = AIHelper.IntentOfSentence(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IntentOfSentence_question_mark_with_space()
    {
      const string Source = "you are twenty aren't you? ";
      const Intention expected = Intention.Question;
      Intention result = AIHelper.IntentOfSentence(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IntentOfSentence_question_mark_with_space_before_and_after()
    {
      const string Source = "you are twenty aren't you ? ";
      const Intention expected = Intention.Question;
      Intention result = AIHelper.IntentOfSentence(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IntentOfSentence_question_why()
    {
      const string Source = "Why are you so nice with me";
      const Intention expected = Intention.Question;
      Intention result = AIHelper.IntentOfSentence(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IntentOfSentence_question_who()
    {
      const string Source = "Who are you";
      const Intention expected = Intention.Question;
      Intention result = AIHelper.IntentOfSentence(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IntentOfSentence_question_when()
    {
      const string Source = "When did you leave";
      const Intention expected = Intention.Question;
      Intention result = AIHelper.IntentOfSentence(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IntentOfSentence_question_where()
    {
      const string Source = "Where have you been";
      const Intention expected = Intention.Question;
      Intention result = AIHelper.IntentOfSentence(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IntentOfSentence_question_does_upperCase()
    {
      const string Source = "DOES she know she's pretty";
      const Intention expected = Intention.Question;
      Intention result = AIHelper.IntentOfSentence(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IntentOfSentence_question_does_lowerCase()
    {
      const string Source = "does she know she's pretty";
      const Intention expected = Intention.Question;
      Intention result = AIHelper.IntentOfSentence(Source);
      Assert.AreEqual(result, expected);
    }
    
    [TestMethod]
    public void TestMethod_IntentOfSentence_question_have()
    {
      const string Source = "Have you ever seen a space saucer";
      const Intention expected = Intention.Question;
      Intention result = AIHelper.IntentOfSentence(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IntentOfSentence_question_has()
    {
      const string Source = "Has he been sick lately";
      const Intention expected = Intention.Question;
      Intention result = AIHelper.IntentOfSentence(Source);
      Assert.AreEqual(result, expected);
    }
    
    [TestMethod]
    public void TestMethod_IntentOfSentence_question_is()
    {
      const string Source = "is she angry";
      const Intention expected = Intention.Question;
      Intention result = AIHelper.IntentOfSentence(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IntentOfSentence_question_isnt()
    {
      const string Source = "Isn't she lovely";
      const Intention expected = Intention.Question;
      Intention result = AIHelper.IntentOfSentence(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IntentOfSentence_question_whose()
    {
      const string Source = "Whose pen is it";
      const Intention expected = Intention.Question;
      Intention result = AIHelper.IntentOfSentence(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_IntentOfSentence_question_which()
    {
      const string Source = "Which galaxy are we in";
      const Intention expected = Intention.Question;
      Intention result = AIHelper.IntentOfSentence(Source);
      Assert.AreEqual(result, expected);
    }
  }
}