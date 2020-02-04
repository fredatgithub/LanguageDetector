using AIOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAIOne
{
  [TestClass]
  public class UnitTestRemoveWrongCharacters
  {
    [TestMethod]
    public void TestMethod_UnitTestRemoveWrongCharacters_one_word()
    {
      const string Source = "twenty-eight";
      string expected = "twentyeight";
      string result = AIHelper.RemoveWrongCharacters(Source);
      Assert.AreEqual(result, expected);
    }
  }
}