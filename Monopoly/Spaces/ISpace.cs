using Monopoly.CommandFactories;

namespace Monopoly.Spaces
{
    public interface ISpace
    {
        ICommandFactory EnterSpaceCommandFactory { get; }
        ICommandFactory LandOnSpaceCommandFactory { get; }
    }
}
