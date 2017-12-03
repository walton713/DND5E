using TechTalk.SpecFlow;

namespace DND5EUnitTests
{
    [Binding]
    public class DiceRollerSteps
    {
        [Given(@"I have a Dice Roller")]
        public void GivenIHaveADiceRoller()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I roll a dice with (.*) sides")]
        public void WhenIRollADiceWithSides(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"it returns a number between (.*) and (.*)")]
        public void ThenItReturnsANumberBetweenAnd(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
    }
}