using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;
using Monopoly.CommandFactories;
using Monopoly.Commands;

namespace MonopolyTests.CommandFactories
{
    [TestClass]
    public class GoToJailCommandFactoryTests
    {
        private const Int32 JailSpaceLocation = 10;

        private Player player;
        private GoToJailCommandFactory goToJailCommandFactory;

        public GoToJailCommandFactoryTests()
        {
            player = new Player();
            goToJailCommandFactory = new GoToJailCommandFactory(JailSpaceLocation);
        }

        [TestMethod]
        public void CreateReturnsNewGoToJailCommand()
        {
            var command = goToJailCommandFactory.Create(player);

            Assert.IsInstanceOfType(command, typeof(IGoToJailCommand));
        }

    }
}
