using Monopoly.Commands;

namespace Monopoly.Spaces
{
    public class IncomeTaxSpace : ISpace
    {
        public ICommand EnterSpaceCommand { get; private set; }
        public ICommand LandOnSpaceCommand { get; private set; }

        public IncomeTaxSpace(INullCommand enterSpaceCommand, IIncomeTaxCommand landOnSpaceCommand)
        {
            EnterSpaceCommand = enterSpaceCommand;
            LandOnSpaceCommand = landOnSpaceCommand;
        }
    }
}
