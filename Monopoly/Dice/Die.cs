using System;
using Monopoly.Random;

namespace Monopoly.Dice
{
    public class Die : IDie
    {
        private IRandom random;
        private Int32 numberOfSides;

        public Die(IRandom random, Int32 numberOfSides)
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
