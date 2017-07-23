using Monopoly.Dice;
using Monopoly.Movement;

namespace Monopoly.Turns
{
    public class TurnTaker : ITurnTaker
    {
        private IDiceRoller diceRoller;
        private IMovementService movementService;

        public TurnTaker(IDiceRoller diceRoller, IMovementService movementService)
        {
            this.diceRoller = diceRoller;
            this.movementService = movementService;
        }

        public void TakeTurn(Player player)
        {
            var diceRoll = diceRoller.RollDice();
            movementService.MoveToken(player.Token, diceRoll);
            player.TurnsTaken++;
        }
    }
}
