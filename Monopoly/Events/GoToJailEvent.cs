using System;

namespace Monopoly.Events
{
    public class GoToJailEvent : IGoToJailEvent
    {
        private Int32 jailLocation;

        public GoToJailEvent(Int32 jailLocation)
        {
            this.jailLocation = jailLocation;
        }

        public void Act(Player player)
        {
            player.Location = jailLocation;
        }
    }
}
