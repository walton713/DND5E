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
        [Test]
        public void testCharacterCreationButtonOpensCharacterCreationWindow()
        {
            var applicationDirectory = TestContext.CurrentContext.TestDirectory;
            var applicationPath = Path.Combine(applicationDirectory, "DND5E.exe");
            Application app = Application.Launch(applicationPath);
            Window window = app.GetWindow("DND5E", InitializeOption.NoCache);

            Button button = window.Get<Button>("characterCreateBtn");
            button.Click();

            Assert.That(app.GetWindow("Character Creation", InitializeOption.NoCache), Is.Not.Null);

            app.Close();
        }
    }
}
