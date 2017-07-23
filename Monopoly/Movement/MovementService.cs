using System;
using System.Linq;
using Monopoly.Events;

namespace Monopoly.Movement
{
    public class MovementService : IMovementService
    {
        private GameBoard gameBoard;
        private IEventFactory eventDispatcher;

        public MovementService(GameBoard gameBoard, IEventFactory eventDispatcher)
        {
            this.gameBoard = gameBoard;
            this.eventDispatcher = eventDispatcher;
        }

        public void MovePlayer(Player player, Int32 spacesToMove)
        {
            for (int i = 0; i < spacesToMove; i++)
                AdvancePlayerByOneSpace(player);
        }

        private void AdvancePlayerByOneSpace(Player player)
        {
            player.Location = (player.Location + 1) % gameBoard.Spaces.Count();
            var currentSpace = gameBoard.Spaces.ElementAt(player.Location);
            var enterSpaceEvent = eventDispatcher.CreateEnterSpaceEvent(player, currentSpace);
            enterSpaceEvent.Act();
        }
    }
}
