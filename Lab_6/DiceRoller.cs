using System;

namespace Lab_6
{
    class DiceRoller
    {
        public static int getRandom(int sides)
        {
            Random rand = new Random();

            return rand.Next(1, sides + 1);
        }
    }
}
