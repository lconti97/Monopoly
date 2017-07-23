using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;
using Monopoly.Movement;

namespace MonopolyTests
{
    [TestClass]
    public class MovementServiceTests
    {
        private Int32 numberOfSpacesOnBoard;
        private Token token;
        private MovementService movementService;

        public MovementServiceTests()
        {
            numberOfSpacesOnBoard = 40;
            token = new Token();
            movementService = new MovementService(numberOfSpacesOnBoard);
        }

        [TestMethod]
        public void MovePlayerSevenSpaces()
        {
            var initialLocation = 0;
            token.Location = initialLocation;
            var spacesToMove = 7;

            movementService.MoveToken(token, spacesToMove);

            Assert.AreEqual(spacesToMove, token.Location);
        }

        [TestMethod]
        public void MovePlayerOnLastSpaceSixSpaces()
        {
            var initialLocation = numberOfSpacesOnBoard - 1;
            token.Location = initialLocation;
            var spacesToMove = 6;

            movementService.MoveToken(token, spacesToMove);

            var expectedLocation = spacesToMove - 1;
            Assert.AreEqual(expectedLocation, token.Location);
        }
    }
}
