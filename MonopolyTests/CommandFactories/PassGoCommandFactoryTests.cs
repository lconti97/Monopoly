using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;
using Monopoly.CommandFactories;
using Monopoly.Commands;

namespace MonopolyTests.CommandFactories
{
    [TestClass]
    public class PassGoCommandFactoryTests
    {
        private const Int32 PassGoPay = 200;

        private Player player;
        private PassGoCommandFactory passGoCommandFactory;

        public PassGoCommandFactoryTests()
        {
            player = new Player();
            passGoCommandFactory = new PassGoCommandFactory(PassGoPay);
        }

        [TestMethod]
        public void CreateReturnsNewPassGoCommand()
        {
            var command = passGoCommandFactory.Create(player);

            Assert.IsInstanceOfType(command, typeof(IPassGoCommand));
        }
    }
}
