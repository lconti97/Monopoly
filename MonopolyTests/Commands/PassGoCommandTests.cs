using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;
using Monopoly.Commands;

namespace MonopolyTests.Commands
{
    [TestClass]
    public class PassGoCommandTests
    {
        private Int32 passGoPay;
        private Player player;
        private PassGoCommand passGoCommand;

        public PassGoCommandTests()
        {
            passGoPay = 200;
            player = new Player();
            passGoCommand = new PassGoCommand(passGoPay);
        }

        [TestMethod]
        public void ActIncreasesPlayerBalanceByPassGoPay()
        {
            var initialBalance = 100;
            player.Balance = initialBalance;

            passGoCommand.Execute(player);

            var expectedBalance = initialBalance + passGoPay;
            Assert.AreEqual(expectedBalance, player.Balance);
        }
    }
}
