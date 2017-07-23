using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;
using Monopoly.Events;

namespace MonopolyTests.Events
{
    [TestClass]
    public class IncomeTaxEventTests
    {
        private Int32 maxDeduction = 200;
        private Int32 incomeTaxPercentage = 10;
        private Player player;
        private GameBoard gameBoard;
        private IncomeTaxEvent incomeTaxEvent;

        public IncomeTaxEventTests()
        {
            player = new Player();
            gameBoard = new GameBoard();
            incomeTaxEvent = new IncomeTaxEvent(maxDeduction, incomeTaxPercentage);
        }

        [TestMethod]
        public void ActWhenPlayerBalanceIsLessThanTwoThousandDecreasesBalanceByTenPercent()
        {
            var initialBalance = 1800;
            player.Balance = initialBalance;

            incomeTaxEvent.Act(player, gameBoard);

            var expectedDeduction = initialBalance / 10;
            var expectedBalance = initialBalance - expectedDeduction;
            Assert.AreEqual(expectedBalance, player.Balance);
        }

        [TestMethod]
        public void ActWhenPlayerBalanceIsGreaterThanTwoThousandDecreasesBalanceByTwoHundred()
        {
            var initialBalance = 2200;
            player.Balance = initialBalance;

            incomeTaxEvent.Act(player, gameBoard);

            var expectedDeduction = maxDeduction;
            var expectedBalance = initialBalance - expectedDeduction;
            Assert.AreEqual(expectedBalance, player.Balance);
        }

        [TestMethod]
        public void ActWhenPlayerBalanceIsZeroDoesNotDecreaseBalance()
        {
            var initialBalance = 0;
            player.Balance = initialBalance;

            incomeTaxEvent.Act(player, gameBoard);

            Assert.AreEqual(initialBalance, player.Balance);
        }

        [TestMethod]
        public void ActWhenPlayerBalanceIsTwoThousandDecreasesBalanceByTwoThousand()
        {
            var initialBalance = 2000;
            player.Balance = initialBalance;

            incomeTaxEvent.Act(player, gameBoard);

            var expectedDeduction = maxDeduction;
            var expectedBalance = initialBalance - expectedDeduction;
            Assert.AreEqual(expectedBalance, player.Balance);
        }
    }
}
