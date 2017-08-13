using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;
using Monopoly.CommandFactories;
using Monopoly.Commands;
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
        private Mock<INullCommandFactory> mockEnterSpaceCommandFactory;
        private Mock<INullCommandFactory> mockLandOnSpaceCommandFactory;
        private Mock<INullCommand> mockEnterSpaceNullCommand;
        private Mock<INullCommand> mockLandOnSpaceNullCommand;
        private Player player;
        private MovementService movementService;

        public MovementServiceTests()
        {
            numberOfSpaces = 40;
            gameBoard = new GameBoard();
            mockEnterSpaceCommandFactory = new Mock<INullCommandFactory>();
            mockLandOnSpaceCommandFactory = new Mock<INullCommandFactory>();
            mockEnterSpaceNullCommand = new Mock<INullCommand>();
            mockLandOnSpaceNullCommand = new Mock<INullCommand>();
            player = new Player();
            movementService = new MovementService(gameBoard);
        }

        [TestInitialize]
        public void Setup()
        {
            gameBoard.Spaces = CreateGenericSpaces(numberOfSpaces);
            mockEnterSpaceCommandFactory.Setup(f => f.Create(player)).Returns(mockEnterSpaceNullCommand.Object);
            mockLandOnSpaceCommandFactory.Setup(f => f.Create(player)).Returns(mockLandOnSpaceNullCommand.Object);
        }

        private IEnumerable<ISpace> CreateGenericSpaces(Int32 numberOfSpaces)
        {
            var spaces = new List<ISpace>();

            for (int i = 0; i < numberOfSpaces; i++)
                spaces.Add(new GenericSpace(mockEnterSpaceCommandFactory.Object, mockLandOnSpaceCommandFactory.Object));

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
        public void MovePlayerCallsActOnEnterSpaceCommandForEachSpaceThePlayerEnters()
        {
            var spacesToMove = 3;

            movementService.MovePlayer(player, spacesToMove);

            mockEnterSpaceCommandFactory.Verify(e => e.Create(player), Times.Exactly(spacesToMove));
            mockEnterSpaceNullCommand.Verify(c => c.Execute(), Times.Exactly(spacesToMove));
        }

        [TestMethod]
        public void MovePlayerCallsActOnLastSpaceLandOnCommand()
        {
            var spacesToMove = 3;

            movementService.MovePlayer(player, spacesToMove);

            mockLandOnSpaceCommandFactory.Verify(f => f.Create(player), Times.Once());
            mockLandOnSpaceNullCommand.Verify(c => c.Execute(), Times.Once());
        }
    }
}
