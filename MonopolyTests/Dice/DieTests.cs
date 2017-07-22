using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly.Dice;

namespace MonopolyTests
{
    [TestClass]
    public class DieTests
    {
        private Random random;
        private Int32 numberOfSides;
        private Die die;

        public DieTests()
        {
            random = new Random();
            numberOfSides = 6;
            die = new Die(random, numberOfSides);
        }

        [TestMethod]
        public void RollCanReturnEveryNumberBetweenOneAndNumberOfSidesInclusive()
        {
            var timesToRoll = 1000;
            var rolls = new Int32[6];

            for (var i = 0; i < timesToRoll; i++)
            {
                var roll = die.Roll();
                var slotInZeroIndexedArray = roll - 1;
                rolls[slotInZeroIndexedArray]++;
            }

            Assert.IsTrue(rolls.All(r => r > 0));
        }
    }
}
