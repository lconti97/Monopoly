using System;

namespace Monopoly.Movement
{
    public interface IMovementService
    {
        void MovePlayer(Player player, Int32 spacesToMove);
    }
}
