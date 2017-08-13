using System;
using Monopoly.Commands;

namespace Monopoly.CommandFactories
{
    public class PassGoCommandFactory : IPassGoCommandFactory
    {
        private Int32 passGoPay;

        public PassGoCommandFactory(Int32 passGoPay)
        {
            this.passGoPay = passGoPay;
        }

        public ICommand Create(Player player)
        {
            return new PassGoCommand(player, passGoPay);
        }
    }
}
