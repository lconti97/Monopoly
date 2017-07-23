using System;
using Monopoly.Random;
using Monopoly.Turns;

namespace Monopoly.Game
{
    public class GameRunner : IGameRunner
    {
        private IRandomizer randomizer;
        private IGameValidator gameValidator;
        private ITurnTaker turnTaker;

        public GameRunner(IRandomizer randomizer, IGameValidator gameValidator, ITurnTaker turnTaker)
        {
            this.randomizer = randomizer;
            this.gameValidator = gameValidator;
            this.turnTaker = turnTaker;
        }

        public void Run(Game game)
        {
            gameValidator.Validate(game);
            var randomizedPlayers = randomizer.Randomize(game.Players);
            PlayRounds(game);
        }

        private void PlayRounds(Game game)
        {
            var roundsToPlay = game.RoundsToPlay;

            for (Int32 round = 0; round < roundsToPlay; round++)
                PlayRound(game);
        }

        private void PlayRound(Game game)
        {
            foreach (var player in game.Players)
                turnTaker.TakeTurn(player);

            game.RoundsPlayed++;
        }
    }
}
