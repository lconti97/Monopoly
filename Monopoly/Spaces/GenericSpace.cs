using Monopoly.Events;

namespace Monopoly.Spaces
{
    public class GenericSpace : ISpace
    {
        public IEvent EnterSpaceEvent { get; private set; }
        public IEvent LandOnSpaceEvent { get; private set; }

        public GenericSpace(INopEvent enterSpaceEvent, INopEvent landOnSpaceEvent)
        {
            EnterSpaceEvent = enterSpaceEvent;
            LandOnSpaceEvent = landOnSpaceEvent;
        }
    }
}
