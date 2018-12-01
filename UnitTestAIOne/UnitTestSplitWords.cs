using System.Collections.Generic;
using System.Linq;
using AIOne;
using AIOneStandard;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAIOne
{
  [TestClass]
  public class UnitTestSplitWords
  {
    [TestMethod]
    public void TestMethod_SplitWords_one_word_once()
    {
      const string source = "very";
      Dictionary<string, int> expected = new Dictionary<string, int> { { "very", 1 } };
      Dictionary<string, int> result = AIHelper.SplitWords(source);
      Assert.AreEqual(result.Count, expected.Count);
      Assert.AreEqual(result["very"], expected["very"]);
      Assert.IsTrue(DictionariesAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_SplitWords_two_words_once()
    {
      const string source = "very long";
      var expected = new Dictionary<string, int> { { "very", 1 }, { "long", 1 }, };
      Dictionary<string, int> result = AIHelper.SplitWords(source);
      Assert.AreEqual(result.Count, expected.Count);
      Assert.IsTrue(DictionariesAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_SplitWords_long_sentence_many_words_several_times()
    {
      const string source = "a long long time ago in a galaxy far far away";
      var expected = new Dictionary<string, int>
      {
        { "long", 2 }, { "time", 1 }, { "ago", 1 }, { "in", 1 }, { "galaxy", 1 },
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

    [TestMethod]
    public void TestMethod_SplitWords_only_numbers()
    {
      const string source = "123456789";
      var expected = new Dictionary<string, int>();
      Dictionary<string, int> result = AIHelper.SplitWords(source);
      Assert.AreEqual(result.Count, expected.Count);
      Assert.IsTrue(DictionariesAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_SplitWords_two_numbers()
    {
      const string source = "123456789 galaxy";
      var expected = new Dictionary<string, int>{{"galaxy", 1}};
      Dictionary<string, int> result = AIHelper.SplitWords(source);
      Assert.AreEqual(result.Count, expected.Count);
      Assert.IsTrue(DictionariesAreEqualed(result, expected));
    }

    [TestMethod]
    public void TestMethod_SplitWords_one_number_plus_numbers()
    {
      const string source = "123456789 galaxy51";
      var expected = new Dictionary<string, int> { { "galaxy", 1 } };
      Dictionary<string, int> result = AIHelper.SplitWords(source);
      Assert.AreEqual(result.Count, expected.Count);
      Assert.IsTrue(DictionariesAreEqualed(result, expected));
    }
  }
}