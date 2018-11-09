using System.Collections.Generic;
using System.Linq;
using AIOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAIOne
{
  [TestClass]
  public class UnitTestSplitWords
  {
    [TestMethod]
    public void TestMethod_CreateDictionary_one_word_once()
    {
      const string source = "a";
      Dictionary<string, int> expected = new Dictionary<string, int> { { "a", 1 } };
      Dictionary<string, int> result = AIHelper.SplitWords(source);
      Assert.AreEqual(result.Count, expected.Count);
      Assert.AreEqual(result["a"], expected["a"]);
      Assert.IsTrue(DictionariesAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_CreateDictionary_two_words_once()
    {
      const string source = "a long";
      var expected = new Dictionary<string, int> { { "a", 1 }, { "long", 1 }, };
      Dictionary<string, int> result = AIHelper.SplitWords(source);
      Assert.AreEqual(result.Count, expected.Count);
      Assert.IsTrue(DictionariesAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_CreateDictionary_long_sentence_many_words_several_times()
    {
      const string source = "a long long time ago in a galaxy far far away";
      var expected = new Dictionary<string, int>
      {
        { "a", 2 }, { "long", 2 }, { "time", 1 }, { "ago", 1 }, { "in", 1 }, { "galaxy", 1 },
        { "far", 2 }, { "away", 1 }
      };
      Dictionary<string, int> result = AIHelper.SplitWords(source);
      Assert.AreEqual(result.Count, expected.Count);
      Assert.IsTrue(DictionariesAreEqualed(result, expected));
    }

    public static bool DictionariesAreEqualed(Dictionary<string, int> source, Dictionary<string, int> target)
    {
      bool result = true;
      if (source.Count != target.Count)
      {
        return false;
      }

      if (source.Except(target).Any())
      {
        return false;
      }

      return result;
    }
  }
}