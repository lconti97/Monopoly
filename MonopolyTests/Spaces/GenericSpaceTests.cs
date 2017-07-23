using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly.Events;
using Monopoly.Spaces;
using Moq;

namespace MonopolyTests.Spaces
{
    [TestClass]
    public class GenericSpaceTests
    {
        private Mock<INopEvent> mockNopEvent1;
        private Mock<INopEvent> mockNopEvent2;
        private GenericSpace genericSpace;

        public GenericSpaceTests()
        {
            mockNopEvent1 = new Mock<INopEvent>();
            mockNopEvent2 = new Mock<INopEvent>();
            genericSpace = new GenericSpace(mockNopEvent1.Object, mockNopEvent2.Object);
        }

        [TestMethod]
        public void ConstructorInitializesEnterSpaceEventToNopEvent()
        {
            Assert.AreEqual(mockNopEvent1.Object, genericSpace.EnterSpaceEvent);
        }

        [TestMethod]
        public void ConstructorInitializesLandOnSpaceEventToNopEvent()
        {
            Assert.AreEqual(mockNopEvent2.Object, genericSpace.LandOnSpaceEvent);
        }
    }
}
