using System;

namespace Monopoly
{
    public interface IPlayer
    {
        Int32 Location { get; set; }
        void TakeTurn();
    }
}
