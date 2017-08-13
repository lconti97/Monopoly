using System;

namespace Monopoly.Commands
{
    public class PassGoCommand : IPassGoCommand
    {
        private Player player;
        private Int32 passGoPay;

        public PassGoCommand(Player player, Int32 passGoPay)
        {
            this.player = player;
            this.passGoPay = passGoPay;
        }

        public void Execute()
        {
            player.Balance += passGoPay;
        }
    }
}
