using Monopoly.Dice;

namespace Monopoly
{
    public class Player : IPlayer
    {
        private IDiceRoller diceRoller;
        private IMovementService movementService;
        public Token token;

        public Player(IDiceRoller diceRoller, IMovementService movementService, Token token)
        {
            this.diceRoller = diceRoller;
            this.movementService = movementService;
            this.token = token;
        }

        public void TakeTurn()
        {
            var diceRoll = diceRoller.RollDice();
            movementService.MoveToken(token, diceRoll);
        }
    }
}
