using AIOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAIOne
{
  [TestClass]
  public class UnitTestHelper
  {
    [TestMethod]
    public void TestMethod_RemovePunctuation_period()
    {
      const string source = "galaxy.";
      const string expected = "galaxy ";
      string result = AIHelper.RemovePunctuation(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RemovePunctuation_semi_colon()
    {
      const string source = "galaxy;";
      const string expected = "galaxy ";
      string result = AIHelper.RemovePunctuation(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RemovePunctuation_comma()
    {
      const string source = "galaxy,";
      const string expected = "galaxy ";
      string result = AIHelper.RemovePunctuation(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RemovePunctuation_colon()
    {
      const string source = "galaxy:";
      const string expected = "galaxy ";
      string result = AIHelper.RemovePunctuation(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RemovePunctuation_no_punctuation_sign()
    {
      const string source = "galaxy";
      const string expected = "galaxy";
      string result = AIHelper.RemovePunctuation(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_RemovePunctuation_string_empty()
    {
      const string source = "";
      const string expected = "";
      string result = AIHelper.RemovePunctuation(source);
      Assert.AreEqual(result, expected);
    }
  }
}