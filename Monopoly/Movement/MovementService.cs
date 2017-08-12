using System;
using System.Linq;
using Monopoly.Spaces;

namespace Monopoly.Movement
{
    public class MovementService : IMovementService
    {
        private GameBoard gameBoard;

        public MovementService(GameBoard gameBoard)
        {
            this.gameBoard = gameBoard;
        }

        public void MovePlayer(Player player, Int32 spacesToMove)
        {
            for (int i = 0; i < spacesToMove; i++)
                AdvancePlayerByOneSpace(player);

            var currentSpace = GetCurrentSpace(player, gameBoard);
            currentSpace.LandOnSpaceEvent.Act(player);
        }

        private ISpace GetCurrentSpace(Player player, GameBoard gameBoard)
        {
            return gameBoard.Spaces.ElementAt(player.Location);
        }

        private void AdvancePlayerByOneSpace(Player player)
        {
            player.Location = (player.Location + 1) % gameBoard.Spaces.Count();
            var currentSpace = GetCurrentSpace(player, gameBoard);
            var enterSpaceEvent = currentSpace.EnterSpaceEvent;
            enterSpaceEvent.Act(player);
        }
    }
}
