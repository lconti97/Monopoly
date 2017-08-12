using Monopoly.Commands;

namespace Monopoly.Spaces
{
    public class GenericSpace : ISpace
    {
        public ICommand EnterSpaceCommand { get; private set; }
        public ICommand LandOnSpaceCommand { get; private set; }

        public GenericSpace(INullCommand enterSpaceCommand, INullCommand landOnSpaceCommand)
        {
            EnterSpaceCommand = enterSpaceCommand;
            LandOnSpaceCommand = landOnSpaceCommand;
        }
    }
}
