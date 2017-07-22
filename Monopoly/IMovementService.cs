using System;

namespace Monopoly
{
    public interface IMovementService
    {
        void MovePlayer(IPlayer player, Int32 spacesToMove);
    }
}
