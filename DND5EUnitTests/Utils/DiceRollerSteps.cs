﻿using DND5E.Utils;
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

        [When(@"I roll (.*) dice with (.*) sides")]
        public void WhenIRollDiceWithSides(int num, int size)
        {
            returnValue = dr.Roll(num, size);
        }

        [Then(@"it returns a number between (.*) and (.*)")]
        public void ThenItReturnsANumberBetweenAnd(int num, int max)
        {
            Assert.That(returnValue, Is.InRange(num, max));
        }

        [When(@"I roll ability scores")]
        public void WhenIRollAbilityScores()
        {
            returnValue = dr.RollAbilityScore();
        }
    }
}