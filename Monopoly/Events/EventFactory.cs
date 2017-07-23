using Monopoly.Spaces;

namespace Monopoly.Events
{
    public class EventFactory : IEventFactory
    {
        public IEvent CreateEnterSpaceEvent(Player player, ISpace space)
        {
            if (space is GoSpace)
                return new PassGoEvent(player);
            else
                return new NopEvent();
        }
    }
}
