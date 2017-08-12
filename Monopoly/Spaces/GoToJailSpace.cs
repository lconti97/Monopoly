using Monopoly.Commands;

namespace Monopoly.Spaces
{
    public class GoToJailSpace : ISpace
    {
        public ICommand EnterSpaceCommand { get; private set; }
        public ICommand LandOnSpaceCommand { get; private set; }

        public GoToJailSpace(INullCommand enterSpaceCommand, IGoToJailCommand landOnSpaceCommand)
        {
            EnterSpaceCommand = enterSpaceCommand;
            LandOnSpaceCommand = landOnSpaceCommand;
        }
    }
}
