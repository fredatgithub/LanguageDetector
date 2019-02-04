using AIOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAIOne
{
  [TestClass]
  public class UnitTestToneLevels
  {
    // TODO write them all in English, then french then as a integer
    #region English Tests

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

    #endregion

    #region Tone level up by number

    [TestMethod]
    public void TestMethod_ToneLevels_by_number_SerenityOfBeingness_40()
    {
      const double Source = 40.0;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_by_number_Postulates_30()
    {
      const double Source = 30.0;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }
    
    [TestMethod]
    public void TestMethod_ToneLevels_Games_22()
    {
      const double Source = 22.0;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Action_20()
    {
      const double Source = 20.0;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Exhilaration_8()
    {
      const double Source = 8.0;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Aesthetic_6()
    {
      const double Source = 6.0;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Enthusiasm_4()
    {
      const double Source = 4.0;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Cheerfulness_3_5()
    {
      const double Source = 3.5;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_StrongInterest_3_3()
    {
      const double Source = 3.3;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Conservatism_3()
    {
      const double Source = 3.5;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_MildInterest_2_9()
    {
      const double Source = 2.9;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Contented_2_8()
    {
      const double Source = 2.8;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Disinterested_2_6()
    {
      const double Source = 2.6;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Boredom_2_5()
    {
      const double Source = 2.5;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Monotony_2_4()
    {
      const double Source = 2.4;
      const bool expected = true;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Antagonism_2()
    {
      const double Source = 2.0;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Hostility_1_9()
    {
      const double Source = 1.9;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Pain_1_8()
    {
      const double Source = 1.8;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Anger_1_5()
    {
      const double Source = 1.5;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Hate_1_4()
    {
      const double Source = 1.4;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Resentment_1_3()
    {
      const double Source = 1.3;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_NoSympathy_1_2()
    {
      const double Source = 1.2;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_UnexpressedResentment_1_15()
    {
      const double Source = 1.15;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_CovertHostility_1_1()
    {
      const double Source = 1.1;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Anxiety_1_02()
    {
      const double Source = 1.02;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Fear_1()
    {
      const double Source = 1.0;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Despair_0_98()
    {
      const double Source = 0.98;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Terror_0_96()
    {
      const double Source = 0.96;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Numb_0_94()
    {
      const double Source = 0.94;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Sympathy_0_9()
    {
      const double Source = 0.9;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Propitiation_0_8()
    {
      const double Source = 0.8;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Grief_0_5()
    {
      const double Source = 0.5;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_MakingAmends_0_375()
    {
      const double Source = 0.375;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Undeserving_0_3()
    {
      const double Source = 0.3;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_SelfAbasement_0_2()
    {
      const double Source = 0.2;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Victim_0_1()
    {
      const double Source = 0.1;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Hopeless_0_07()
    {
      const double Source = 0.07;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Apathy_0_05()
    {
      const double Source = 0.05;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Useless_0_03()
    {
      const double Source = 0.03;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_Dying_0_01()
    {
      const double Source = 0.01;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_BodyDeath_0()
    {
      const double Source = 0;
      const bool expected = false;
      bool result = AIHelper.IsUpTone(Source);
      Assert.AreEqual(result, expected);
    }

    #endregion

    #region Tone level down by number

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_by_number_SerenityOfBeingness_40()
    {
      const double Source = 40.0;
      const bool expected = false;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_by_number_Postulates_30()
    {
      const double Source = 30.0;
      const bool expected = false;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Games_22()
    {
      const double Source = 22.0;
      const bool expected = false;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Action_20()
    {
      const double Source = 20.0;
      const bool expected = false;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Exhilaration_8()
    {
      const double Source = 8.0;
      const bool expected = false;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Aesthetic_6()
    {
      const double Source = 6.0;
      const bool expected = false;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Enthusiasm_4()
    {
      const double Source = 4.0;
      const bool expected = false;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Cheerfulness_3_5()
    {
      const double Source = 3.5;
      const bool expected = false;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_StrongInterest_3_3()
    {
      const double Source = 3.3;
      const bool expected = false;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Conservatism_3()
    {
      const double Source = 3.5;
      const bool expected = false;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_MildInterest_2_9()
    {
      const double Source = 2.9;
      const bool expected = false;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Contented_2_8()
    {
      const double Source = 2.8;
      const bool expected = false;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Disinterested_2_6()
    {
      const double Source = 2.6;
      const bool expected = false;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Boredom_2_5()
    {
      const double Source = 2.5;
      const bool expected = false;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Monotony_2_4()
    {
      const double Source = 2.4;
      const bool expected = false;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Antagonism_2()
    {
      const double Source = 2.0;
      const bool expected = true;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Hostility_1_9()
    {
      const double Source = 1.9;
      const bool expected = true;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Pain_1_8()
    {
      const double Source = 1.8;
      const bool expected = true;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Anger_1_5()
    {
      const double Source = 1.5;
      const bool expected = true;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Hate_1_4()
    {
      const double Source = 1.4;
      const bool expected = true;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Resentment_1_3()
    {
      const double Source = 1.3;
      const bool expected = true;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_NoSympathy_1_2()
    {
      const double Source = 1.2;
      const bool expected = true;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_UnexpressedResentment_1_15()
    {
      const double Source = 1.15;
      const bool expected = true;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_CovertHostility_1_1()
    {
      const double Source = 1.1;
      const bool expected = true;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Anxiety_1_02()
    {
      const double Source = 1.02;
      const bool expected = true;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Fear_1()
    {
      const double Source = 1.0;
      const bool expected = true;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Despair_0_98()
    {
      const double Source = 0.98;
      const bool expected = true;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Terror_0_96()
    {
      const double Source = 0.96;
      const bool expected = true;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Numb_0_94()
    {
      const double Source = 0.94;
      const bool expected = true;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Sympathy_0_9()
    {
      const double Source = 0.9;
      const bool expected = true;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Propitiation_0_8()
    {
      const double Source = 0.8;
      const bool expected = true;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Grief_0_5()
    {
      const double Source = 0.5;
      const bool expected = true;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_MakingAmends_0_375()
    {
      const double Source = 0.375;
      const bool expected = true;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Undeserving_0_3()
    {
      const double Source = 0.3;
      const bool expected = true;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_SelfAbasement_0_2()
    {
      const double Source = 0.2;
      const bool expected = true;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Victim_0_1()
    {
      const double Source = 0.1;
      const bool expected = true;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Hopeless_0_07()
    {
      const double Source = 0.07;
      const bool expected = true;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Apathy_0_05()
    {
      const double Source = 0.05;
      const bool expected = true;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Useless_0_03()
    {
      const double Source = 0.03;
      const bool expected = true;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_Dying_0_01()
    {
      const double Source = 0.01;
      const bool expected = true;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_DownTone_ToneLevels_BodyDeath_0()
    {
      const double Source = 0;
      const bool expected = true;
      bool result = AIHelper.IsDownTone(Source);
      Assert.AreEqual(result, expected);
    }

    #endregion

    #region Number of French tone levels
    
    [TestMethod]
    public void TestMethod_ToneLevels_English_41_of_them()
    {
      // if there are not 41 levels then alter-is
      var source = AIHelper.GetEnToneLevelByName();
      const int expected = 41;
      int result = source.Count;
      Assert.AreEqual(result, expected);
    }

    [TestMethod]
    public void TestMethod_ToneLevels_French_41_of_them()
    {
      // if there are not 41 levels then alter-is
      var source = AIHelper.GetFrToneLevelByName();
      const int expected = 41;
      int result = source.Count;
      Assert.AreEqual(result, expected);
    }

    #endregion

    // TODO add English tests
  }
}