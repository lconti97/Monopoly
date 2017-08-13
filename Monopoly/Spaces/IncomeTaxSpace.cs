using Monopoly.CommandFactories;

namespace Monopoly.Spaces
{
    public class IncomeTaxSpace : ISpace
    {
        public ICommandFactory EnterSpaceCommandFactory { get; private set; }
        public ICommandFactory LandOnSpaceCommandFactory { get; private set; }

        public IncomeTaxSpace(INullCommandFactory enterSpaceCommandFactory, IIncomeTaxCommandFactory landOnSpaceCommandFactory)
        {
            EnterSpaceCommandFactory = enterSpaceCommandFactory;
            LandOnSpaceCommandFactory = landOnSpaceCommandFactory;
        }
    }
}
