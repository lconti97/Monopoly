using Monopoly.Spaces;

namespace Monopoly.Events
{
    public interface IEventFactory
    {
        IEvent CreateEnterSpaceEvent(ISpace space);
    }
}
