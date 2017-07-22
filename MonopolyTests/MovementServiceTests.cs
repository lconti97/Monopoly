using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;
using Moq;

namespace MonopolyTests
{
    [TestClass]
    public class MovementServiceTests
    {
        private Int32 numberOfSpacesOnBoard;
        private Mock<IPlayer> mockPlayer;
        private MovementService movementService;

        public MovementServiceTests()
        {
            numberOfSpacesOnBoard = 40;
            mockPlayer = new Mock<IPlayer>();
            movementService = new MovementService(numberOfSpacesOnBoard);
        }

        [TestMethod]
        public void MovePlayerSevenSpaces()
        {
            var initialLocation = 0;
            mockPlayer.Setup(p => p.Location).Returns(initialLocation);
            var spacesToMove = 7;

            movementService.MovePlayer(mockPlayer.Object, spacesToMove);

            mockPlayer.VerifySet(p => p.Location = spacesToMove);
            mockPlayer.VerifyAll();
        }

        [TestMethod]
        public void MovePlayerOnLastSpaceSixSpaces()
        {
            var initialLocation = numberOfSpacesOnBoard - 1;
            mockPlayer.Setup(p => p.Location).Returns(initialLocation);
            var spacesToMove = 6;

            movementService.MovePlayer(mockPlayer.Object, spacesToMove);

            mockPlayer.VerifySet(p => p.Location = spacesToMove - 1);
            mockPlayer.VerifyAll();
        }
    }
}
