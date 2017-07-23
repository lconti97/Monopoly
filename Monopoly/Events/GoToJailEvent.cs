using System;

namespace Monopoly.Events
{
    public class GoToJailEvent : IEvent
    {
        public void Act(Player player, GameBoard gameBoard)
        {
            player.Location = gameBoard.JailSpaceLocation;
        }
    }
}
