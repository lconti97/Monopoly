using System;

namespace Monopoly.Commands
{
    public class GoToJailCommand : IGoToJailCommand
    {
        private Int32 jailLocation;

        public GoToJailCommand(Int32 jailLocation)
        {
            this.jailLocation = jailLocation;
        }

        public void Execute(Player player)
        {
            player.Location = jailLocation;
        }
    }
}
