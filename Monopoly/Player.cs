using System;
using Monopoly.Dice;

namespace Monopoly
{
    public class Player : IPlayer
    {
        public Int32 Location { get; set; }
        private IDiceRoller diceRoller;
        private IMovementService movementService;

        public Player(IDiceRoller diceRoller, IMovementService movementService)
        {
            this.diceRoller = diceRoller;
            this.movementService = movementService;
        }

        public void TakeTurn()
        {
            var diceRoll = diceRoller.RollDice();
            movementService.MovePlayer(this, diceRoll);
        }
    }
}
