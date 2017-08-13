using Monopoly.CommandFactories;

namespace Monopoly.Spaces
{
    public class GoToJailSpace : ISpace
    {
        public ICommandFactory EnterSpaceCommandFactory { get; private set; }
        public ICommandFactory LandOnSpaceCommandFactory { get; private set; }

        public GoToJailSpace(INullCommandFactory enterSpaceCommandFactory, IGoToJailCommandFactory landOnSpaceCommandFactory)
        {
            EnterSpaceCommandFactory = enterSpaceCommandFactory;
            LandOnSpaceCommandFactory = landOnSpaceCommandFactory;
        }
    }
}
