using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;
using Monopoly.Dice;
using Moq;

namespace MonopolyTests
{
    [TestClass]
    public class PlayerTests
    {
        private Mock<IDiceRoller> mockDiceRoller;
        private Mock<IMovementService> mockMovementService;
        private Player player;

        public PlayerTests()
        {
            mockDiceRoller = new Mock<IDiceRoller>();
            mockMovementService = new Mock<IMovementService>();
            player = new Player(mockDiceRoller.Object, mockMovementService.Object);
        }

        [TestMethod]
        public void TakeTurnRollsDice()
        {
            player.TakeTurn();

            mockDiceRoller.Verify(d => d.RollDice(), Times.Once());
        }

        [TestMethod]
        public void PlayerLocationStartsAtZero()
        {
            Assert.AreEqual(0, player.Location);
        }

        [TestMethod]
        public void TakeTurnWhenDiceRollSevenAdvancesLocationBySeven()
        {
            var diceRoll = 7;
            mockDiceRoller.Setup(d => d.RollDice()).Returns(diceRoll).Verifiable();

            player.TakeTurn();

            mockDiceRoller.Verify();
            mockMovementService.Verify(s => s.MovePlayer(player, diceRoll), Times.Once());
        }

        [TestMethod]
        public void TakeTurnGivenPlayerStartsOnLastSpaceWhenDiceRollSixEndsPlayerOnLocationFive()
        {
            var diceRoll = 6;
            mockDiceRoller.Setup(d => d.RollDice()).Returns(diceRoll).Verifiable();

            player.TakeTurn();

            mockMovementService.Verify(s => s.MovePlayer(player, diceRoll), Times.Once());
        }
    }
}
