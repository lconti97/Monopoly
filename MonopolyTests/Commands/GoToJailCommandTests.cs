using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;
using Monopoly.Commands;

namespace MonopolyTests.Commands
{
    [TestClass]
    public class GoToJailCommandTests
    {
        private Int32 jailSpaceIndex;
        private Player player;
        private GameBoard gameBoard;
        private GoToJailCommand goToJailCommand;

        public GoToJailCommandTests()
        {
            jailSpaceIndex = 3;
            player = new Player();
            gameBoard = new GameBoard();
            goToJailCommand = new GoToJailCommand(jailSpaceIndex);
        }

        [TestMethod]
        public void ActMovesPlayerToJailSpace()
        {
            goToJailCommand.Execute(player);

            Assert.AreEqual(jailSpaceIndex, player.Location);
        }
    }
}
