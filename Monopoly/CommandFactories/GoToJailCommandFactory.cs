using System;
using Monopoly.Commands;

namespace Monopoly.CommandFactories
{
    public class GoToJailCommandFactory : IGoToJailCommandFactory
    {
        private Int32 jailSpaceLocation;
        public GoToJailCommandFactory(Int32 jailSpaceLocation)
        {
            this.jailSpaceLocation = jailSpaceLocation;
        }

        public ICommand Create(Player player)
        {
            return new GoToJailCommand(player, jailSpaceLocation);
        }
    }
}
