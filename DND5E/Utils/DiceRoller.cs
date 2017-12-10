using System;

namespace DND5E.Utils
{
    public class DiceRoller
    {
        public Random Rand { get; set; }
        public DiceRoller()
        {
            Rand = new Random();
        }

        public int Roll(int sizeOfDie, int numberOfDie = 1)
        {
            int value = 0;

            for (int i = 1; i <= numberOfDie; i++)
            {
                value += Rand.Next(1, sizeOfDie + 1);
            }
            return value;
        }

        public int RollAbilityScore()
        {
            int[] rolls = new int[] { Roll(6, 1), Roll(6, 1), Roll(6, 1), Roll(6, 1) };
            Array.Sort(rolls);
            return rolls[1] + rolls[2] + rolls[3];
        }
    }
}
