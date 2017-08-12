using Monopoly.Commands;

namespace Monopoly.Spaces
{
    public class GoSpace : ISpace
    {
        public ICommand EnterSpaceCommand { get; private set; }

        public ICommand LandOnSpaceCommand { get; private set; }

        public GoSpace(IPassGoCommand enterSpaceCommand, INullCommand landOnSpaceCommand)
        {
            EnterSpaceCommand = enterSpaceCommand;
            LandOnSpaceCommand = landOnSpaceCommand;
        }
    }
}
