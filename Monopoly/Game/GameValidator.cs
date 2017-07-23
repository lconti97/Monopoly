using System;
using System.Linq;

namespace Monopoly.Game
{
    public class GameValidator : IGameValidator
    {
        public void Validate(Game game)
        {
            var players = game.Players;
            var numberOfPlayers = players.Count();
            if (players.Count() < 2)
                throw new InvalidOperationException("Cannot start a game with fewer than two players");
            if (players.Count() > 8)
                throw new InvalidOperationException("Cannot start a game with more than eight players");
        }
    }
}
