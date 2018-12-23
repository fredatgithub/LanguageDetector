using System;
using System.Collections.Generic;
using AIOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAIOne
{
  [TestClass]
  public class UnitTestSplitWordsUsingRegex
  {
    [TestMethod]
    public void TestMethod_SplitWordsUsingRegex_one_word()
    {
      const string Source = "very";
      string[] expected = new string[1] { "very" };
      string[] result = AIHelper.SplitWordsUsingRegex(Source);
      Assert.IsTrue(ArraysAreEquals(result, expected));
    }

    [TestMethod]
    public void TestMethod_SplitWordsUsingRegex_two_words()
    {
      const string Source = "very long";
      string[] expected = new string[2] { "very", "long" };
      string[] result = AIHelper.SplitWordsUsingRegex(Source);
      Assert.IsTrue(ArraysAreEquals(result, expected));
    }

    public static bool ArraysAreEquals(string[] result, string[] expected)
    {
      bool equality = true;
      if (result.Length != expected.Length)
      {
        return false;
      }

      for (int i = 0; i < expected.Length; i++)
      {
        if (result[i] != expected[i])
        {
          equality = false;
          break;
        }
      }

      return equality;
    }

    [TestMethod]
    public void TestMethod_SplitWordsUsingRegex_long_sentence_many_words_several_times()
    {
      const string Source = "a long long time ago in a galaxy far far away";
      string[] expected = new string[11] { "a", "long", "long", "time", "ago", "in", "a", "galaxy", "far", "far", "away" };
      string[] result = AIHelper.SplitWordsUsingRegex(Source);
      Assert.IsTrue(ArraysAreEquals(result, expected));
    }

    [TestMethod]
    public void TestMethod_SplitWordsUsingRegex_only_numbers()
    {
      const string source = "123456789";
      string[] expected = new string[1] { "123456789" };
      string[] result = AIHelper.SplitWordsUsingRegex(source);
      Assert.IsTrue(ArraysAreEquals(result, expected));
    }

    [TestMethod]
    public void TestMethod_SplitWordsUsingRegex_numbers_plus_one_word()
    {
      const string source = "123456789 galaxy";
      string[] expected = new string[2] { "123456789", "galaxy" };
      string[] result = AIHelper.SplitWordsUsingRegex(source);
      Assert.IsTrue(ArraysAreEquals(result, expected));
    }

    [TestMethod]
    public void TestMethod_SplitWordsUsingRegex_numbers_plus_one_word_plus_numbers()
    {
      const string source = "123456789 galaxy51";
      string[] expected = new string[2] { "123456789", "galaxy51" };
      string[] result = AIHelper.SplitWordsUsingRegex(source);
      Assert.IsTrue(ArraysAreEquals(result, expected));
    }
  }
}