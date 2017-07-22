using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly.Dice;
using Moq;

namespace MonopolyTests
{
    [TestClass]
    public class DiceRollerTests
    {
        private Mock<IDie> mockDie1;
        private Mock<IDie> mockDie2;
        private IEnumerable<IDie> mockDice;
        private DiceRoller diceRoller;

        public DiceRollerTests()
        {
            mockDie1 = new Mock<IDie>();
            mockDie2 = new Mock<IDie>();
            mockDice = new[] { mockDie1.Object, mockDie2.Object };
            diceRoller = new DiceRoller(mockDice);
        }

        [TestMethod]
        public void RollReturnsSumOfAllDieRolls()
        {
            var firstDieRoll = 4;
            var secondDieRoll = 3;
            mockDie1.Setup(d => d.Roll()).Returns(firstDieRoll);
            mockDie2.Setup(d => d.Roll()).Returns(secondDieRoll);
            var expectedRollTotal = firstDieRoll + secondDieRoll;

            var rollTotal = diceRoller.RollDice();

            Assert.AreEqual(expectedRollTotal, rollTotal);
            mockDie1.VerifyAll();
            mockDie2.VerifyAll();
        }
    }
}
