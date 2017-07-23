using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly.Events;
using Monopoly.Spaces;

namespace MonopolyTests.Events
{
    [TestClass]
    public class EventFactoryTests
    {
        private EventFactory eventDispatcher;

        public EventFactoryTests()
        {
            eventDispatcher = new EventFactory();
        }

        [TestMethod]
        public void CreateEnterSpaceEventForGoSpaceCreatesPassGoEvent()
        {
            var resultEvent = eventDispatcher.CreateEnterSpaceEvent(new GoSpace());

            Assert.IsInstanceOfType(resultEvent, typeof(PassGoEvent));
        }

        [TestMethod]
        public void CreateEnterSpaceEventForGenericSpaceCreatesNopEvent()
        {
            var resultEvent = eventDispatcher.CreateEnterSpaceEvent(new GenericSpace());

            Assert.IsInstanceOfType(resultEvent, typeof(NopEvent));
        }

        [TestMethod]
        public void CreateLandOnEventForGoToJailSpaceCreatesGoToJailEvent()
        {
            var resultEvent = eventDispatcher.CreateLandOnSpaceEvent(new GoToJailSpace());

            Assert.IsInstanceOfType(resultEvent, typeof(GoToJailEvent));
        }
        
        [TestMethod]
        public void CreateLandOnEventForGenericSpaceCreatesNopEvent()
        {
            var resultEvent = eventDispatcher.CreateLandOnSpaceEvent(new GenericSpace());

            Assert.IsInstanceOfType(resultEvent, typeof(NopEvent));
        }
    }
}
