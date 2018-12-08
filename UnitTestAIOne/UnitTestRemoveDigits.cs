namespace UnitTestAIOne
{
  using AIOne;

  using Microsoft.VisualStudio.TestTools.UnitTesting;

  [TestClass]
  public class UnitTestRemoveDigits
  {
    [TestMethod]
    public void TestMethod_RemoveDigits_only_numbers()
    {
      const string Source = "0123456789";
      const string Expected = "";
      string result = AIHelper.RemoveDigits(Source);
      Assert.AreEqual(result, Expected);
    }

    [TestMethod]
    public void TestMethod_RemoveDigits_one_letter_between_numbers()
    {
      const string Source = "01234a56789";
      const string Expected = "a";
      string result = AIHelper.RemoveDigits(Source);
      Assert.AreEqual(result, Expected);
    }

    [TestMethod]
    public void TestMethod_RemoveDigits_two_letters_between_numbers()
    {
      const string Source = "01234a5678b9";
      const string Expected = "ab";
      string result = AIHelper.RemoveDigits(Source);
      Assert.AreEqual(result, Expected);
    }

    [TestMethod]
    public void TestMethod_RemoveDigits_1_end()
    {
      const string Source = "galaxy1";
      const string Expected = "galaxy";
      string result = AIHelper.RemoveDigits(Source);
      Assert.AreEqual(result, Expected);
    }

    [TestMethod]
    public void TestMethod_RemoveDigits_1_start()
    {
      const string Source = "1galaxy";
      const string Expected = "galaxy";
      string result = AIHelper.RemoveDigits(Source);
      Assert.AreEqual(result, Expected);
    }

    [TestMethod]
    public void TestMethod_RemoveDigits_1_start_and_end()
    {
      const string Source = "1galaxy1";
      const string Expected = "galaxy";
      string result = AIHelper.RemoveDigits(Source);
      Assert.AreEqual(result, Expected);
    }

    [TestMethod]
    public void TestMethod_RemoveDigits_1_start_and_end_and_middle()
    {
      const string Source = "1gal3axy1";
      const string Expected = "galaxy";
      string result = AIHelper.RemoveDigits(Source);
      Assert.AreEqual(result, Expected);
    }

    [TestMethod]
    public void TestMethod_RemoveDigits_two_words()
    {
      const string Source = "a galaxy3";
      const string Expected = "a galaxy";
      string result = AIHelper.RemoveDigits(Source);
      Assert.AreEqual(result, Expected);
    }

    [TestMethod]
    public void TestMethod_RemoveDigits_one_sentence_one_number()
    {
      const string Source = "a long long time ago in a galaxy3 far far away";
      const string Expected = "a long long time ago in a galaxy far far away";
      string result = AIHelper.RemoveDigits(Source);
      Assert.AreEqual(result, Expected);
    }

    [TestMethod]
    public void TestMethod_RemoveDigits_one_sentence_two_number()
    {
      const string Source = "a long long time ago2 in a galaxy3 far far away";
      const string Expected = "a long long time ago in a galaxy far far away";
      string result = AIHelper.RemoveDigits(Source);
      Assert.AreEqual(result, Expected);
    }
  }
}