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

    [TestMethod]
    public void TestMethod_ToneLevels_Antagonism()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Antagonism;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Hostility()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Hostility;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

[TestMethod]
    public void TestMethod_ToneLevels_Pain()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Pain;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

[TestMethod]
    public void TestMethod_ToneLevels_Anger()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Anger;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

[TestMethod]
    public void TestMethod_ToneLevels_Hate()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Hate;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

[TestMethod]
    public void TestMethod_ToneLevels_Resentment()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Resentment;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

[TestMethod]
    public void TestMethod_ToneLevels_NoSympathy()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.NoSympathy;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

[TestMethod]
    public void TestMethod_ToneLevels_UnexpressedResentment()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.UnexpressedResentment;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

[TestMethod]
    public void TestMethod_ToneLevels_CovertHostility()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.CovertHostility;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

[TestMethod]
    public void TestMethod_ToneLevels_Anxiety()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Anxiety;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

[TestMethod]
    public void TestMethod_ToneLevels_Fear()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Fear;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

[TestMethod]
    public void TestMethod_ToneLevels_Despair()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Despair;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

[TestMethod]
    public void TestMethod_ToneLevels_Terror()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Terror;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

[TestMethod]
    public void TestMethod_ToneLevels_Numb()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Numb;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

[TestMethod]
    public void TestMethod_ToneLevels_Sympathy()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Sympathy;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

[TestMethod]
    public void TestMethod_ToneLevels_Propitiation()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Propitiation;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

[TestMethod]
    public void TestMethod_ToneLevels_Grief()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Grief;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

[TestMethod]
    public void TestMethod_ToneLevels_MakingAmends()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.MakingAmends;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

[TestMethod]
    public void TestMethod_ToneLevels_Undeserving()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Undeserving;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

[TestMethod]
    public void TestMethod_ToneLevels_SelfAbasement()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.SelfAbasement;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

[TestMethod]
    public void TestMethod_ToneLevels_Victim()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Victim;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

[TestMethod]
    public void TestMethod_ToneLevels_Hopeless()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Hopeless;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

[TestMethod]
    public void TestMethod_ToneLevels_Apathy()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Apathy;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

[TestMethod]
    public void TestMethod_ToneLevels_Useless()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Useless;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

[TestMethod]
    public void TestMethod_ToneLevels_Dying()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.Dying;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

[TestMethod]
    public void TestMethod_ToneLevels_BodyDeath()
    {
      const AiEnumerations.ToneLevelEn Source = AiEnumerations.ToneLevelEn.BodyDeath;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }
  }
}