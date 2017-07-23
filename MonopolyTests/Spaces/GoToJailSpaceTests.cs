using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly.Events;
using Monopoly.Spaces;
using Moq;

namespace MonopolyTests.Spaces
{
    [TestClass]
    public class GoToJailSpaceTests
    {
        private Mock<INopEvent> mockNopEvent;
        private Mock<IGoToJailEvent> mockGoToJailEvent;
        private GoToJailSpace goToJailSpace;

        public GoToJailSpaceTests()
        {
            mockNopEvent = new Mock<INopEvent>();
            mockGoToJailEvent = new Mock<IGoToJailEvent>();
            goToJailSpace = new GoToJailSpace(mockNopEvent.Object, mockGoToJailEvent.Object);
        }

        [TestMethod]
        public void ConstructorInitializesEnterSpaceEventToNopEvent()
        {
            Assert.AreEqual(mockNopEvent.Object, goToJailSpace.EnterSpaceEvent);
        }

        [TestMethod]
        public void ConstructorInitializesLandOnSpaceEventToGoToJailEvent()
        {
            Assert.AreEqual(mockGoToJailEvent.Object, goToJailSpace.LandOnSpaceEvent);
        }
    }
}
