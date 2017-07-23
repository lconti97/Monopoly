using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;
using Monopoly.Random;
using Moq;

namespace MonopolyTests
{
    [TestClass]
    public class GameTests
    {
        private Mock<IRandomizer> mockRandomizer;
        private Game game;

        public GameTests()
        {
            mockRandomizer = new Mock<IRandomizer>();
            game = new Game(mockRandomizer.Object);
        }

        [TestMethod]
        public void StartWithTwoPlayersSucceeds()
        {
            var players = CreatePlayers(2);

            game.Start(players);
        }

        private IEnumerable<IPlayer> CreatePlayers(Int32 numberOfPlayers)
        {
            var players = new List<IPlayer>();

            for (int i = 0; i < numberOfPlayers; i++)
            {
                players.Add(new Mock<IPlayer>().Object);
            }

            return players;
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void StartWithLessThanTwoPlayersFails()
        {
            var players = CreatePlayers(1);

            game.Start(players);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void StartWithMoreThanEightPlayersFails()
        {
            var players = CreatePlayers(9);

            game.Start(players);
        }

        [TestMethod]
        public void StartCallsRandomize()
        {
            var players = CreatePlayers(2);

            game.Start(players);

            mockRandomizer.Verify(r => r.Randomize(players));
        }
    }
}
