using System;
using System.Collections.Generic;
using System.Linq;
using Monopoly.Random;

namespace Monopoly
{
    public class Game
    {
        private IRandomizer randomizer;

        public Game(IRandomizer randomizer)
        {
            this.randomizer = randomizer;
        }

        public void Start(IEnumerable<IPlayer> players)
        {
            ValidatePlayers(players);
            var randomizedPlayers = randomizer.Randomize(players);
        }

        private void ValidatePlayers(IEnumerable<IPlayer> players)
        {
            var numberOfPlayers = players.Count();
            if (players.Count() < 2)
                throw new InvalidOperationException("Cannot start a game with fewer than two players");
            if (players.Count() > 8)
                throw new InvalidOperationException("Cannot start a game with more than eight players");
        }
    }
}
