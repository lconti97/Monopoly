using System;

namespace Monopoly.Dice
{
    public class Die : IDie
    {
        private Random random;
        private Int32 numberOfSides;

        public Die(Random random, Int32 numberOfSides)
        {
            this.random = random;
            this.numberOfSides = numberOfSides;
        }

        public Int32 Roll()
        {
            return random.Next(1, numberOfSides + 1);
        }
    }
}
