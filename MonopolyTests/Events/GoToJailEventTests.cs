using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;
using Monopoly.Events;

namespace MonopolyTests.Events
{
    [TestClass]
    public class GoToJailEventTests
    {
        private Int32 jailSpaceIndex;
        private Player player;
        private GameBoard gameBoard;
        private GoToJailEvent goToJailEvent;

        public GoToJailEventTests()
        {
            jailSpaceIndex = 3;
            player = new Player();
            gameBoard = new GameBoard();
            goToJailEvent = new GoToJailEvent(jailSpaceIndex);
        }

        [TestMethod]
        public void ActMovesPlayerToJailSpace()
        {
            goToJailEvent.Act(player, gameBoard);

            Assert.AreEqual(jailSpaceIndex, player.Location);
        }
    }
}
