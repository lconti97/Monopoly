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
        private Token token;
        private Player player;

        public PlayerTests()
        {
            mockDiceRoller = new Mock<IDiceRoller>();
            mockMovementService = new Mock<IMovementService>();
            token = new Token();
            player = new Player(mockDiceRoller.Object, mockMovementService.Object, token);
        }

        [TestMethod]
        public void TakeTurnRollsDice()
        {
            player.TakeTurn();

            mockDiceRoller.Verify(d => d.RollDice(), Times.Once());
        }

        [TestMethod]
        public void TakeTurnMovesTokenBasedOnDieRoll()
        {
            var diceRollTotal = 6;
            mockDiceRoller.Setup(r => r.RollDice()).Returns(diceRollTotal);

            player.TakeTurn();

            mockMovementService.Verify(s => s.MoveToken(token, diceRollTotal));
            mockDiceRoller.VerifyAll();
        }
    }
}
