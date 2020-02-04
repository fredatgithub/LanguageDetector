using AIOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAIOne
{
  [TestClass]
  public class UnitTestRemoveWrongCharacters
  {
    [TestMethod]
    public void TestMethod_UnitTestRemoveWrongCharacters_one_dash()
    {
      const string Source = "twenty-eight";
      string expected = "twentyeight";
      string result = AIHelper.RemoveWrongCharacters(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_UnitTestRemoveWrongCharacters_one_space()
    {
      const string Source = "twenty nine";
      string expected = "twenty,nine";
      string result = AIHelper.RemoveWrongCharacters(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_UnitTestRemoveWrongCharacters_space_and_period()
    {
      const string Source = "one place. One time. One job";
      string expected = "one,place,One,time,One,job";
      string result = AIHelper.RemoveWrongCharacters(Source);
      Assert.AreEqual(result, expected);
    }
  }
}