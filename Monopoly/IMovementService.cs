using System;

namespace Monopoly
{
    public interface IMovementService
    {
        void MoveToken(Token token, Int32 spacesToMove);
    }
}
