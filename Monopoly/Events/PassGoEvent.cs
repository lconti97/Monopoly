using System;

namespace Monopoly.Events
{
    public class PassGoEvent : IEvent
    {
        public const Int32 PassGoPay = 200;

        private Player player;

        public PassGoEvent(Player player)
        {
            this.player = player;
        }

        public void Act()
        {
            player.Balance += PassGoPay;
        }
    }
}
