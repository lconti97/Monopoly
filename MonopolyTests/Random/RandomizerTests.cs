using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly.Random;

namespace MonopolyTests.Random
{
    [TestClass]
    public class RandomizerTests
    {
        private Randomizer randomizer;

        public RandomizerTests()
        {
            randomizer = new Randomizer();
        }

        [TestMethod]
        public void RandomizeCanReturnAllPermutationsOfList()
        {
            // value == index
            var values = new[] { 0, 1, 2 };
            var valueOccursFirst = new[] { false, false, false };
            var timesToRun = 100;

            for (int i = 0; i < timesToRun; i++)
            {
                var randomizedEnumerable = randomizer.Randomize(values);
                var firstValue = randomizedEnumerable.ElementAt(0);

                valueOccursFirst[firstValue] = true;
            }

            CollectionAssert.DoesNotContain(valueOccursFirst, false);
        }
    }
}
