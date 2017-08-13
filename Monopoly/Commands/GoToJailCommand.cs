using System;

namespace Monopoly.Commands
{
    public class GoToJailCommand : IGoToJailCommand
    {
        private Player player;
        private Int32 jailLocation;

        public GoToJailCommand(Player player, Int32 jailLocation)
        {
            this.player = player;
            this.jailLocation = jailLocation;
        }

        public void Execute()
        {
            player.Location = jailLocation;
        }
    }
}
