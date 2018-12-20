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
  }
}