using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;
using Monopoly.Game;
using Monopoly.Random;
using Monopoly.Turns;
using Moq;

namespace MonopolyTests.Game
{
    [TestClass]
    public class GameRunnerTests
    {
        private Mock<IRandomizer> mockRandomizer;
        private Mock<IGameValidator> mockGameValidator;
        private Mock<ITurnTaker> mockTurnTaker;
        private IEnumerable<Player> players;
        private Int32 roundsToPlay;
        private Monopoly.Game.Game game;
        private GameRunner gameRunner;

        public GameRunnerTests()
        {
            mockRandomizer = new Mock<IRandomizer>();
            mockGameValidator = new Mock<IGameValidator>();
            mockTurnTaker = new Mock<ITurnTaker>();
            players = new[] { new Player(), new Player() };
            roundsToPlay = 20;
            game = new Monopoly.Game.Game { Players = players, RoundsToPlay = roundsToPlay };
            gameRunner = new GameRunner(mockRandomizer.Object, mockGameValidator.Object, mockTurnTaker.Object);
        }

        [TestMethod]
        public void RunCallsValidate()
        {
            gameRunner.Run(game);

            mockGameValidator.Verify(v => v.Validate(game));
        }

        [TestMethod]
        public void RunCallsRandomizeOnce()
        {
            gameRunner.Run(game);

            mockRandomizer.Verify(r => r.Randomize(players), Times.Once());
        }

        [TestMethod]
        public void RunUpdatesGameRoundsPlayed()
        {
            gameRunner.Run(game);

            Assert.AreEqual(roundsToPlay, game.RoundsPlayed);
        }

        [TestMethod]
        public void RunCallsTakeTurnOnEachPlayerUntilGameIsFinished()
        {
            gameRunner.Run(game);

            foreach (var player in players)
            {
                mockTurnTaker.Verify(t => t.TakeTurn(player), Times.Exactly(game.RoundsPlayed));
            }
        }
    }
}
