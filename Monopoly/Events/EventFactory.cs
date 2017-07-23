using Monopoly.Spaces;

namespace Monopoly.Events
{
    public class EventFactory : IEventFactory
    {
        public IEvent CreateEnterSpaceEvent(ISpace space)
        {
            if (space is GoSpace)
                return new PassGoEvent();
            else
                return new NopEvent();
        }

        public IEvent CreateLandOnSpaceEvent(ISpace space)
        {
            if (space is GoToJailSpace)
                return new GoToJailEvent();
            else
                return new NopEvent();
        }
    }
}
