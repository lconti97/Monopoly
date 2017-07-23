using Monopoly.Events;

namespace Monopoly.Spaces
{
    public interface ISpace
    {
        IEvent EnterSpaceEvent { get; }
        IEvent LandOnSpaceEvent { get; }
    }
}
