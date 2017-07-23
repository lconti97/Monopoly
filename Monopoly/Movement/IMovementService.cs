using System;

namespace Monopoly.Movement
{
    public interface IMovementService
    {
        void MoveToken(Token token, Int32 spacesToMove);
    }
}
