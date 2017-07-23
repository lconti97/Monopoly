using Monopoly.Spaces;

namespace Monopoly.Events
{
    public interface IEventFactory
    {
        IEvent CreateEnterSpaceEvent(Player player, ISpace space);
    }
}
