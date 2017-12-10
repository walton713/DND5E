using NUnit.Framework;
using System;
using System.IO;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace DND5EUITests
{
    [TestFixture]
    public class CharacterCreationTests
    {
        string applicationDirectory;
        string applicationPath;
        Application app;
        Window mainWindow;
        Window characterCreationWindow;
        Button characterCreateBtn;
        Button abilityScoresBtn;
        int abilityLabelValue = 0;

        [SetUp]
        public void SetUp()
        {
            applicationDirectory = TestContext.CurrentContext.TestDirectory;
            applicationPath = Path.Combine(applicationDirectory, "DND5E.exe");
            app = Application.Launch(applicationPath);
            mainWindow = app.GetWindow("DND5E", InitializeOption.NoCache);
            characterCreateBtn = mainWindow.Get<Button>("characterCreateBtn");
            characterCreateBtn.Click();
            characterCreationWindow = app.GetWindow("Character Creation", InitializeOption.NoCache);
        }

        [TearDown]
        public void TearDown()
        {
            if (app != null) app.Kill();
        }

        public void abilityScoreSetUp()
        {
            abilityScoresBtn = characterCreationWindow.Get<Button>("abilityScoresBtn");
            abilityScoresBtn.Click();
        }

        public void getTextValue(string text)
        {
            Int32.TryParse(text, out abilityLabelValue);
        }

        [Test]
        public void TestGenerateAbilityScoresButtonFillsFirstAbilityScoreLabel()
        {
            abilityScoreSetUp();
            TextBox abilityScoresLbl = characterCreationWindow.Get<TextBox>(SearchCriteria.ByAutomationId("abilityScoreTextOne"));

            getTextValue(abilityScoresLbl.Text);

            Assert.That(abilityLabelValue, Is.InRange(3, 18));
        }

        [Test]
        public void TestGenerateAbilityScoresButtonFillsSecondAbilityScoreLabel()
        {
            abilityScoreSetUp();
            TextBox abilityScoresLbl = characterCreationWindow.Get<TextBox>(SearchCriteria.ByAutomationId("abilityScoreTextTwo"));
            getTextValue(abilityScoresLbl.Text);

            Assert.That(abilityLabelValue, Is.InRange(3, 18));
        }

        [Test]
        public void TestGenerateAbilityScoresButtonFillsThirdAbilityScoreLabel()
        {
            abilityScoreSetUp();
            TextBox abilityScoresLbl = characterCreationWindow.Get<TextBox>(SearchCriteria.ByAutomationId("abilityScoreTextThree"));
            getTextValue(abilityScoresLbl.Text);

            Assert.That(abilityLabelValue, Is.InRange(3, 18));
        }

        [Test]
        public void TestGenerateAbilityScoresButtonFillsFourthAbilityScoreLabel()
        {
            abilityScoreSetUp();
            TextBox abilityScoresLbl = characterCreationWindow.Get<TextBox>(SearchCriteria.ByAutomationId("abilityScoreTextFour"));
            getTextValue(abilityScoresLbl.Text);

            Assert.That(abilityLabelValue, Is.InRange(3, 18));
        }

        [Test]
        public void TestGenerateAbilityScoresButtonFillsFifthAbilityScoreLabel()
        {
            abilityScoreSetUp();
            TextBox abilityScoresLbl = characterCreationWindow.Get<TextBox>(SearchCriteria.ByAutomationId("abilityScoreTextFive"));
            getTextValue(abilityScoresLbl.Text);

            Assert.That(abilityLabelValue, Is.InRange(3, 18));
        }

        [Test]
        public void TestGenerateAbilityScoresButtonFillsSixthAbilityScoreLabel()
        {
            abilityScoreSetUp();
            TextBox abilityScoresLbl = characterCreationWindow.Get<TextBox>(SearchCriteria.ByAutomationId("abilityScoreTextSix"));
            getTextValue(abilityScoresLbl.Text);

            Assert.That(abilityLabelValue, Is.InRange(3, 18));
        }
    }
}