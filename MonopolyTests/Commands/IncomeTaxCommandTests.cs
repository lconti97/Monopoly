using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;
using Monopoly.Commands;

namespace MonopolyTests.Commands
{
    [TestClass]
    public class IncomeTaxCommandTests
    {
        private Int32 maxDeduction = 200;
        private Int32 incomeTaxPercentage = 10;
        private Player player;
        private GameBoard gameBoard;
        private IncomeTaxCommand incomeTaxCommand;

        public IncomeTaxCommandTests()
        {
            player = new Player();
            gameBoard = new GameBoard();
            incomeTaxCommand = new IncomeTaxCommand(maxDeduction, incomeTaxPercentage);
        }

        [TestMethod]
        public void ActWhenPlayerBalanceIsLessThanTwoThousandDecreasesBalanceByTenPercent()
        {
            var initialBalance = 1800;
            player.Balance = initialBalance;

            incomeTaxCommand.Execute(player);

            var expectedDeduction = initialBalance / 10;
            var expectedBalance = initialBalance - expectedDeduction;
            Assert.AreEqual(expectedBalance, player.Balance);
        }

        [TestMethod]
        public void ActWhenPlayerBalanceIsGreaterThanTwoThousandDecreasesBalanceByTwoHundred()
        {
            var initialBalance = 2200;
            player.Balance = initialBalance;

            incomeTaxCommand.Execute(player);

            var expectedDeduction = maxDeduction;
            var expectedBalance = initialBalance - expectedDeduction;
            Assert.AreEqual(expectedBalance, player.Balance);
        }

        [TestMethod]
        public void ActWhenPlayerBalanceIsZeroDoesNotDecreaseBalance()
        {
            var initialBalance = 0;
            player.Balance = initialBalance;

            incomeTaxCommand.Execute(player);

            Assert.AreEqual(initialBalance, player.Balance);
        }

        [TestMethod]
        public void ActWhenPlayerBalanceIsTwoThousandDecreasesBalanceByTwoThousand()
        {
            var initialBalance = 2000;
            player.Balance = initialBalance;

            incomeTaxCommand.Execute(player);

            var expectedDeduction = maxDeduction;
            var expectedBalance = initialBalance - expectedDeduction;
            Assert.AreEqual(expectedBalance, player.Balance);
        }
    }
}
