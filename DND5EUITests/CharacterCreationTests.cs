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

        [Test]
        public void testGenerateAbilityScoresButtonFillsFirstAbilityScoreLabel()
        {
            abilityScoreSetUp();
            TextBox abilityScoresLbl = characterCreationWindow.Get<TextBox>(SearchCriteria.ByAutomationId("abilityScoreTextOne"));

            getTextValue(abilityScoresLbl.Text);

            Assert.That(abilityLabelValue, Is.InRange(3, 18));
        }

        [Test]
        public void testGenerateAbilityScoresButtonFillsSecondAbilityScoreLabel()
        {
            abilityScoreSetUp();
            TextBox abilityScoresLbl = characterCreationWindow.Get<TextBox>(SearchCriteria.ByAutomationId("abilityScoreTextTwo"));
            getTextValue(abilityScoresLbl.Text);

            Assert.That(abilityLabelValue, Is.InRange(3, 18));
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

        //[Test]
        //public void testGenerateAbilityScoresButtonFillsThirdAbilityScoreLabel()
        //{

        //}
    }
}