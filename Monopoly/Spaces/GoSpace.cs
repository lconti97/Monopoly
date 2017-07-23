using Monopoly.Events;

namespace Monopoly.Spaces
{
    public class GoSpace : ISpace
    {
        public IEvent EnterSpaceEvent { get; private set; }

        public IEvent LandOnSpaceEvent { get; private set; }

        public GoSpace(IPassGoEvent enterSpaceEvent, INopEvent landOnSpaceEvent)
        {
            EnterSpaceEvent = enterSpaceEvent;
            LandOnSpaceEvent = landOnSpaceEvent;
        }
    }
}
