using System;

namespace Monopoly
{
    public class MovementService : IMovementService
    {
        private Int32 numberOfSpacesOnBoard;

        public MovementService(Int32 numberOfSpacesOnBoard)
        {
            this.numberOfSpacesOnBoard = numberOfSpacesOnBoard;
        }

        public void MovePlayer(IPlayer player, Int32 spacesToMove)
        {
            player.Location = (player.Location + spacesToMove) % numberOfSpacesOnBoard;
        }
    }
}
