using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;
using Monopoly.Events;
using Monopoly.Movement;
using Monopoly.Spaces;
using Moq;

namespace MonopolyTests.Movement
{
    [TestClass]
    public class MovementServiceTests
    {
        private Int32 numberOfSpaces;
        private GameBoard gameBoard;
        private Mock<INopEvent> mockEnterSpaceEvent;
        private Mock<INopEvent> mockLandOnSpaceEvent;
        private Player player;
        private MovementService movementService;

        public MovementServiceTests()
        {
            numberOfSpaces = 40;
            gameBoard = new GameBoard();
            mockEnterSpaceEvent = new Mock<INopEvent>();
            mockLandOnSpaceEvent = new Mock<INopEvent>();
            player = new Player();
            movementService = new MovementService(gameBoard);
        }

        [TestInitialize]
        public void Setup()
        {
            gameBoard.Spaces = CreateGenericSpaces(numberOfSpaces);
        }

        private IEnumerable<ISpace> CreateGenericSpaces(Int32 numberOfSpaces)
        {
            var spaces = new List<ISpace>();

            for (int i = 0; i < numberOfSpaces; i++)
                spaces.Add(new GenericSpace(mockEnterSpaceEvent.Object, mockLandOnSpaceEvent.Object));

            return spaces;
        }

        [TestMethod]
        public void MovePlayerSevenSpaces()
        {
            var initialLocation = 0;
            player.Location = initialLocation;
            var spacesToMove = 7;

            movementService.MovePlayer(player, spacesToMove);

            Assert.AreEqual(spacesToMove, player.Location);
        }

        [TestMethod]
        public void MovePlayerOnLastSpaceSixSpaces()
        {
            var initialLocation = numberOfSpaces - 1;
            player.Location = initialLocation;
            var spacesToMove = 6;

            movementService.MovePlayer(player, spacesToMove);

            var expectedLocation = spacesToMove - 1;
            Assert.AreEqual(expectedLocation, player.Location);
        }

        [TestMethod]
        public void MovePlayerCallsActOnEnterSpaceEventForEachSpaceThePlayerEnters()
        {
            var spacesToMove = 3;

            movementService.MovePlayer(player, spacesToMove);

            mockEnterSpaceEvent.Verify(e => e.Act(player, gameBoard), Times.Exactly(spacesToMove));
        }

        [TestMethod]
        public void MovePlayerCallsActOnLastSpaceLandOnEvent()
        {
            var spacesToMove = 3;

            movementService.MovePlayer(player, spacesToMove);

            mockLandOnSpaceEvent.Verify(e => e.Act(player, gameBoard), Times.Once());
        }
    }
}
