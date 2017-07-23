using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MonopolyTests.Random
{
    [TestClass]
    public class RandomTests
    {
        private Monopoly.Random.Random random;

        public RandomTests()
        {
            random = new Monopoly.Random.Random();
        }

        [TestMethod]
        public void NextReturnsValueBetweenZeroAndMaxValue()
        {
            var timesToRun = 100;
            var maxValue = 5;

            for (int i = 0; i < timesToRun; i++)
            {
                var next = random.Next(maxValue);

                Assert.IsTrue(next >= 0);
                Assert.IsTrue(next < maxValue);
            }
        }

        [TestMethod]
        public void NextReturnsValueBetweenMinValueAndMaxValue()
        {
            var timesToRun = 100;
            var minValue = 1;
            var maxValue = 5;

            for (int i = 0; i < timesToRun; i++)
            {
                var next = random.Next(minValue, maxValue);

                Assert.IsTrue(next >= minValue);
                Assert.IsTrue(next < maxValue);
            }
        }
    }
}
