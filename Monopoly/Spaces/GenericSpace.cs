using Monopoly.CommandFactories;

namespace Monopoly.Spaces
{
    public class GenericSpace : ISpace
    {
        public ICommandFactory EnterSpaceCommandFactory { get; private set; }
        public ICommandFactory LandOnSpaceCommandFactory { get; private set; }

        public GenericSpace(INullCommandFactory enterSpaceCommandFactory, INullCommandFactory landOnSpaceCommandFactory)
        {
            EnterSpaceCommandFactory = enterSpaceCommandFactory;
            LandOnSpaceCommandFactory = landOnSpaceCommandFactory;
        }
    }
}
