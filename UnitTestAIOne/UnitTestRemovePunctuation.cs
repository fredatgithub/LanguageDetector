using AIOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAIOne
{
  [TestClass]
  public class UnitTestHelper
  {
    [TestMethod]
    public void TestMethodRemovePunctuationPeriod()
    {
      const string Source = "galaxy.";
      const string Expected = "galaxy ";
      string result = AIHelper.RemovePunctuation(Source);
      Assert.AreEqual(result, Expected);
    }

    [TestMethod]
    public void TestMethodRemovePunctuationSemiColon()
    {
      const string Source = "galaxy;";
      const string Expected = "galaxy ";
      string result = AIHelper.RemovePunctuation(Source);
      Assert.AreEqual(result, Expected);
    }

    [TestMethod]
    public void TestMethodRemovePunctuationComma()
    {
      const string Source = "galaxy,";
      const string Expected = "galaxy ";
      string result = AIHelper.RemovePunctuation(Source);
      Assert.AreEqual(result, Expected);
    }

    [TestMethod]
    public void TestMethodRemovePunctuationColon()
    {
      const string Source = "galaxy:";
      const string Expected = "galaxy ";
      string result = AIHelper.RemovePunctuation(Source);
      Assert.AreEqual(result, Expected);
    }

    [TestMethod]
    public void TestMethodRemovePunctuationNoPunctuationSign()
    {
      const string Source = "galaxy";
      const string Expected = "galaxy";
      string result = AIHelper.RemovePunctuation(Source);
      Assert.AreEqual(result, Expected);
    }

    [TestMethod]
    public void TestMethodRemovePunctuationStringEmpty()
    {
      const string Source = "";
      const string Expected = "";
      string result = AIHelper.RemovePunctuation(Source);
      Assert.AreEqual(result, Expected);
    }

    [TestMethod]
    public void TestMethodRemovePunctuation_one_letter_word()
    {
      const string Source = "a";
      const string Expected = "a";
      string result = AIHelper.RemovePunctuation(Source);
      Assert.AreEqual(result, Expected);
    }

    [TestMethod]
    public void TestMethodRemovePunctuation_apres()
    {
      const string Source = "après,";
      const string Expected = "après ";
      string result = AIHelper.RemovePunctuation(Source);
      Assert.AreEqual(result, Expected);
    }
  }
}