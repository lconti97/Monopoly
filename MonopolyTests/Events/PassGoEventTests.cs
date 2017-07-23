using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;
using Monopoly.Events;

namespace MonopolyTests.Events
{
    [TestClass]
    public class PassGoEventTests
    {
        private Int32 passGoPay;
        private Player player;
        private PassGoEvent passGoEvent;

        public PassGoEventTests()
        {
            passGoPay = 200;
            player = new Player();
            passGoEvent = new PassGoEvent(passGoPay);
        }

        [TestMethod]
        public void ActIncreasesPlayerBalanceByPassGoPay()
        {
            var initialBalance = 100;
            player.Balance = initialBalance;

            passGoEvent.Act(player, null);

            var expectedBalance = initialBalance + passGoPay;
            Assert.AreEqual(expectedBalance, player.Balance);
        }
    }
}
