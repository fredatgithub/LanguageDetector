using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LanguageDetector;

namespace UnitTestLanguageDetector
{
  [TestClass]
  public class UnitTestCreateDictionary
  {
    [TestMethod]
    public void TestMethod_CreateDictionary_one_word_once()
    {
      const string source = "a";
      Dictionary<string, int> expected = new Dictionary<string, int> {{"a", 1}};
      Dictionary<string, int> result = FormMain.CreateDictionary(source);
      Assert.AreEqual(result.Count, expected.Count);
      //Assert.AreEqual(result.Keys, expected.Keys);
      //Assert.AreEqual(result.Values, expected.Values);
    }

    [TestMethod]
    public void TestMethod_CreateDictionary_two_words_once()
    {
      const string source = "a long";
      Dictionary<string, int> expected = new Dictionary<string, int> { { "a", 1 }, { "long", 1 }, };
      Dictionary<string, int> result = FormMain.CreateDictionary(source);
      Assert.AreEqual(result.Count, expected.Count);
    }

    [TestMethod]
    public void TestMethod_CreateDictionary_long_sentence_many_words_several_times()
    {
      const string source = "a long long time ago in a galaxy far far away";
      Dictionary<string, int> expected = new Dictionary<string, int>
      {
        { "a", 2 }, { "long", 2 }, { "time", 1 }, { "ago", 1 }, { "in", 1 }, { "galaxy", 1 },
        { "far", 2 }, { "away", 1 }
      };
      Dictionary<string, int> result = FormMain.CreateDictionary(source);
      Assert.AreEqual(result.Count, expected.Count);
    }
  }
}