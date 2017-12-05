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
            return Rand.Next(1, sizeOfDie + 1);
        }
    }
}
