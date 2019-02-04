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


  }
}