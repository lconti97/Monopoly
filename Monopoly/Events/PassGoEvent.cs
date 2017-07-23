using System;

namespace Monopoly.Events
{
    public class PassGoEvent : IPassGoEvent
    {
        private Int32 passGoPay;

        public PassGoEvent(Int32 passGoPay)
        {
            this.passGoPay = passGoPay;
        }

        public void Act(Player player, GameBoard gameBoard)
        {
            player.Balance += passGoPay;
        }
    }
}
