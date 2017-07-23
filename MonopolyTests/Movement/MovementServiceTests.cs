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
        private Mock<IEventFactory> mockEventFactory;
        private Mock<IEvent> mockEvent;
        private Player player;
        private MovementService movementService;

        public MovementServiceTests()
        {
            numberOfSpaces = 40;
            gameBoard = CreateGameBoardWithGenericSpaces(numberOfSpaces);
            mockEventFactory = new Mock<IEventFactory>();
            mockEvent = new Mock<IEvent>();
            player = new Player();
            movementService = new MovementService(gameBoard, mockEventFactory.Object);
        }

        [TestInitialize]
        public void Setup()
        {
            mockEventFactory.Setup(f => f.CreateEnterSpaceEvent(It.IsAny<ISpace>())).Returns(mockEvent.Object);
        }

        private GameBoard CreateGameBoardWithGenericSpaces(Int32 numberOfSpaces)
        {
            var spaces = new List<ISpace>();

            for (int i = 0; i < numberOfSpaces; i++)
                spaces.Add(new GenericSpace());

            return new GameBoard { Spaces = spaces };
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
        public void MovePlayerCallsCreateOnEnterSpaceEventForEachSpaceThePlayerEnters()
        {
            var spacesToMove = 3;

            movementService.MovePlayer(player, spacesToMove);

            mockEventFactory.Verify(d => d.CreateEnterSpaceEvent(It.IsAny<ISpace>()), Times.Exactly(spacesToMove));
            mockEvent.Verify(e => e.Act(player, gameBoard), Times.Exactly(spacesToMove));
        }
    }
}
