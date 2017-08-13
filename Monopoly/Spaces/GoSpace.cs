using Monopoly.CommandFactories;

namespace Monopoly.Spaces
{
    public class GoSpace : ISpace
    {
        public ICommandFactory EnterSpaceCommandFactory { get; private set; }

        public ICommandFactory LandOnSpaceCommandFactory { get; private set; }

        public GoSpace(IPassGoCommandFactory enterSpaceCommandFactory, INullCommandFactory landOnSpaceCommandFactory)
        {
            EnterSpaceCommandFactory = enterSpaceCommandFactory;
            LandOnSpaceCommandFactory = landOnSpaceCommandFactory;
        }
    }
}
