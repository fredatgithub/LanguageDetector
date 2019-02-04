using System.Collections.Generic;
using System.Linq;
using AIOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAIOne
{
  [TestClass]
  public class UnitTestToneLevels
  {
    // TODO write them all in English, then french then as a integer
    [TestMethod]
    public void TestMethod_ToneLevels_Serenity_of_beingness()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.SerenityOfBeingness;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Postulates()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Postulates;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Games()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Games;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Action()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Action;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Exhilaration()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Exhilaration;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Aesthetic()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Aesthetic;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Enthusiasm()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Enthusiasm;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

     [TestMethod]
    public void TestMethod_ToneLevels_Cheerfulness()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Cheerfulness;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

     [TestMethod]
    public void TestMethod_ToneLevels_StrongInterest()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.StrongInterest;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

     [TestMethod]
    public void TestMethod_ToneLevels_Conservatism()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Conservatism;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

     [TestMethod]
    public void TestMethod_ToneLevels_MildInterest()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.MildInterest;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

     [TestMethod]
    public void TestMethod_ToneLevels_Contented()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Contented;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

     [TestMethod]
    public void TestMethod_ToneLevels_Disinterested()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Disinterested;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

     [TestMethod]
    public void TestMethod_ToneLevels_Boredom()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Boredom;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

     [TestMethod]
    public void TestMethod_ToneLevels_Monotony()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Monotony;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }



  }
}