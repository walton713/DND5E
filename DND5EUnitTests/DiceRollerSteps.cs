using DND5E.Utils;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace DND5EUnitTests
{
    [Binding]
    public class DiceRollerSteps
    {
        DiceRoller dr;
        int returnValue;

        [Given(@"I have a Dice Roller")]
        public void GivenIHaveADiceRoller()
        {
            dr = new DiceRoller();
        }
        
        [When(@"I roll a dice with (.*) sides")]
        public void WhenIRollADiceWithSides(int size)
        {
            returnValue = dr.Roll(size);
        }

        [Then(@"it returns a number between one and (.*)")]
        public void ThenItReturnsANumberBetweenOneAnd(int size)
        {
            Assert.That(returnValue, Is.InRange(1, size));
        }
    }
}