using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly.Events;
using Monopoly.Spaces;
using Moq;

namespace MonopolyTests.Spaces
{
    [TestClass]
    public class GoSpaceTests
    {
        private Mock<IPassGoEvent> mockPassGoEvent;
        private Mock<INopEvent> mockNopEvent;
        private GoSpace goSpace;

        public GoSpaceTests()
        {
            mockPassGoEvent = new Mock<IPassGoEvent>();
            mockNopEvent = new Mock<INopEvent>();
            goSpace = new GoSpace(mockPassGoEvent.Object, mockNopEvent.Object);
        }

        [TestMethod]
        public void ConstructorInitializesEnterSpaceEventToNewPassGoEvent()
        {
            Assert.AreEqual(mockPassGoEvent.Object, goSpace.EnterSpaceEvent);
        }

        [TestMethod]
        public void ConstructorInitializesLandOnSpaceEventToNewNopEvent()
        {
            Assert.AreEqual(mockNopEvent.Object, goSpace.LandOnSpaceEvent);
        }
    }
}
