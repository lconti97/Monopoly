using Monopoly.Commands;

namespace Monopoly.Spaces
{
    public interface ISpace
    {
        ICommand EnterSpaceCommand { get; }
        ICommand LandOnSpaceCommand { get; }
    }
}
