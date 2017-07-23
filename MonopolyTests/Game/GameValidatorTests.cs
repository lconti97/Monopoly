using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;
using Monopoly.Game;

namespace MonopolyTests.Game
{
    [TestClass]
    public class GameValidatorTests
    {
        private GameValidator validator;

        public GameValidatorTests()
        {
            validator = new GameValidator();
        }

        [TestMethod]
        public void ValidateWithTwoPlayersSucceeds()
        {
            var game = CreateGame(2);

            validator.Validate(game);
        }

        private Monopoly.Game.Game CreateGame(Int32 numberOfPlayers)
        {
            var players = CreatePlayers(numberOfPlayers);
            return new Monopoly.Game.Game { Players = players };
        }

        private IEnumerable<Player> CreatePlayers(Int32 numberOfPlayers)
        {
            var players = new List<Player>();

            for (int i = 0; i < numberOfPlayers; i++)
            {
                players.Add(new Player());
            }

            return players;
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ValidateWithLessThanTwoPlayersFails()
        {
            var game = CreateGame(1);

            validator.Validate(game);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ValidateWithMoreThanEightPlayersFails()
        {
            var game = CreateGame(9);

            validator.Validate(game);
        }
    }
}
