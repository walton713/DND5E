using NUnit.Framework;
using System.IO;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;

namespace DND5EUITests
{
    [TestFixture]
    public class MainWindowTests
    {
        string applicationDirectory;
        string applicationPath;
        Application app;
        Window window;

        [SetUp]
        public void SetUp()
        {
            applicationDirectory = TestContext.CurrentContext.TestDirectory;
            applicationPath = Path.Combine(applicationDirectory, "DND5E.exe");
            app = Application.Launch(applicationPath);
            window = app.GetWindow("DND5E", InitializeOption.NoCache);
        }

        [TearDown]
        public void TearDown()
        {
            if (app != null) app.Kill();
        }

        [Test]
        public void testCharacterCreationButtonOpensCharacterCreationWindow()
        {
            Button button = window.Get<Button>("characterCreateBtn");
            button.Click();

            Assert.That(app.GetWindow("Character Creation", InitializeOption.NoCache).IsCurrentlyActive, Is.True);
        }
    }
}
