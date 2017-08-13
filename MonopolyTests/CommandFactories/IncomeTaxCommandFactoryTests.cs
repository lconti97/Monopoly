using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;
using Monopoly.CommandFactories;
using Monopoly.Commands;

namespace MonopolyTests.CommandFactories
{
    [TestClass]
    public class IncomeTaxCommandFactoryTests
    {
        private const Int32 MaxDeduction = 200;
        private const Int32 IncomeTaxPercentage = 10;

        private Player player;
        private IncomeTaxCommandFactory incomeTaxCommandFactory;

        public IncomeTaxCommandFactoryTests()
        {
            player = new Player();
            incomeTaxCommandFactory = new IncomeTaxCommandFactory(MaxDeduction, IncomeTaxPercentage);
        }

        [TestMethod]
        public void CreateReturnsNewIncomeTaxCommand()
        {
            var command = incomeTaxCommandFactory.Create(player);

            Assert.IsInstanceOfType(command, typeof(IIncomeTaxCommand));
        }
    }
}
