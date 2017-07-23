using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;
using Monopoly.Events;

namespace MonopolyTests.Events
{
    [TestClass]
    public class PassGoEventTests
    {
        private Player player;
        private PassGoEvent passGoEvent;

        public PassGoEventTests()
        {
            player = new Player();
            passGoEvent = new PassGoEvent();
        }

        [TestMethod]
        public void ActIncreasesPlayerBalanceByPassGoPay()
        {
            passGoEvent.Act(player, null);

            Assert.AreEqual(PassGoEvent.PassGoPay, player.Balance);
        }
    }
}
