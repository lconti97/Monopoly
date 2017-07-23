using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly.Dice;
using Monopoly.Random;
using Moq;

namespace MonopolyTests
{
    [TestClass]
    public class DieTests
    {
        private Mock<IRandom> mockRandom;
        private Int32 numberOfSides;
        private Die die;

        public DieTests()
        {
            mockRandom = new Mock<IRandom>();
            numberOfSides = 6;
            die = new Die(mockRandom.Object, numberOfSides);
        }

        [TestMethod]
        public void RollCallsNextOnRandomAndReturnsTheValue()
        {
            var minValueInclusive = 1;
            var maxValueExclusive = 7;
            mockRandom.Setup(r => r.Next(minValueInclusive, maxValueExclusive)).Returns(5);

            die.Roll();

            mockRandom.VerifyAll();
        }
    }
}
