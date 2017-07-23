using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;
using Monopoly.Dice;
using Monopoly.Movement;
using Monopoly.Turns;
using Moq;

namespace MonopolyTests.Turns
{
    [TestClass]
    public class TurnTakerTests
    {
        private Mock<IDiceRoller> mockDiceRoller;
        private Mock<IMovementService> mockMovementService;
        private Player player;
        private TurnTaker turnTaker;

        public TurnTakerTests()
        {
            mockDiceRoller = new Mock<IDiceRoller>();
            mockMovementService = new Mock<IMovementService>();
            player = new Player();
            turnTaker = new TurnTaker(mockDiceRoller.Object, mockMovementService.Object);
        }

        [TestMethod]
        public void TakeTurnRollsDice()
        {
            turnTaker.TakeTurn(player);

            mockDiceRoller.Verify(d => d.RollDice(), Times.Once());
        }

        [TestMethod]
        public void TakeTurnMovesTokenBasedOnDieRoll()
        {
            var diceRollTotal = 6;
            mockDiceRoller.Setup(r => r.RollDice()).Returns(diceRollTotal);

            turnTaker.TakeTurn(player);

            mockMovementService.Verify(s => s.MovePlayer(player, diceRollTotal));
            mockDiceRoller.VerifyAll();
        }

        [TestMethod]
        public void TakeTurnUpdatesPlayerTurnsTaken()
        {
            turnTaker.TakeTurn(player);

            Assert.AreEqual(1, player.TurnsTaken);
        }
    }
}
