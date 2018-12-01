using System.Collections.Generic;
using AIOneStandard;
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
    
     [TestMethod]
    public void TestMethod_CountWordsFromDictionary_three_words_one_each()
    {
      Dictionary<string, int> source = new Dictionary<string, int> { { "man", 2 }, { "men", 2 }, { "girl", 2 } };
      const int expected = 6;
      int result = AIHelper.CountWordsFromDictionary(source);
      Assert.AreEqual(result, expected);
    }
  }
}
