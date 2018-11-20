using System.Collections.Generic;
using System.Linq;
using AIOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAIOne
{
  [TestClass]
  public class UnitTestCountWordsFromDictionary
  {
    [TestMethod]
    public void TestMethod_CountWordsFromDictionary_one_word_one()
    {
      Dictionary<string, int> source = new Dictionary<string, int> { { "a", 1 } };
      const int expected = 1;
      int result = AIHelper.CountWordsFromDictionary(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CountWordsFromDictionary_one_word_two()
    {
      Dictionary<string, int> source = new Dictionary<string, int> { { "a", 2 } };
      const int expected = 2;
      int result = AIHelper.CountWordsFromDictionary(source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_CountWordsFromDictionary_two_words_one_each()
    {
      Dictionary<string, int> source = new Dictionary<string, int> { { "a", 2 }, { "b", 2 } };
      const int expected = 4;
      int result = AIHelper.CountWordsFromDictionary(source);
      Assert.AreEqual(result, expected);
    }
  }
}