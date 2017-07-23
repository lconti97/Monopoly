using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly;
using Monopoly.Events;
using Monopoly.Spaces;

namespace MonopolyTests.Events
{
    [TestClass]
    public class EventFactoryTests
    {
        private Player player;
        private EventFactory eventDispatcher;

        public EventFactoryTests()
        {
            player = new Player();
            eventDispatcher = new EventFactory();
        }

        [TestMethod]
        public void CreateEnterSpaceEventForGoSpaceCreatesPassGoEvent()
        {
            var resultEvent = eventDispatcher.CreateEnterSpaceEvent(player, new GoSpace());

            Assert.IsInstanceOfType(resultEvent, typeof(PassGoEvent));
        }

        [TestMethod]
        public void CreateEnterSpaceEventForGenericSpaceCreatesNopEvent()
        {
            var resultEvent = eventDispatcher.CreateEnterSpaceEvent(player, new GenericSpace());

            Assert.IsInstanceOfType(resultEvent, typeof(NopEvent));
        }
    }
}
