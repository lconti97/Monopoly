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

        public void MoveToken(Token token, Int32 spacesToMove)
        {
            token.Location = (token.Location + spacesToMove) % numberOfSpacesOnBoard;
        }
    }
}
