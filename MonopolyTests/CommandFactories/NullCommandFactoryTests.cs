using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;
using Monopoly.CommandFactories;
using Monopoly.Commands;

namespace MonopolyTests.CommandFactories
{
    [TestClass]
    public class NullCommandFactoryTests
    {
        private Player player;
        private NullCommandFactory nullCommandFactory;

        public NullCommandFactoryTests()
        {
            player = new Player();
            nullCommandFactory = new NullCommandFactory();
        }

        [TestMethod]
        public void CreateReturnsNewNullCommand()
        {
            var command = nullCommandFactory.Create(player);

            Assert.IsInstanceOfType(command, typeof(INullCommand));
        }
    }
}
