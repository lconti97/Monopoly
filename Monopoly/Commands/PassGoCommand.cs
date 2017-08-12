using System;

namespace Monopoly.Commands
{
    public class PassGoCommand : IPassGoCommand
    {
        private Int32 passGoPay;

        public PassGoCommand(Int32 passGoPay)
        {
            this.passGoPay = passGoPay;
        }

        public void Execute(Player player)
        {
            player.Balance += passGoPay;
        }
    }
}
