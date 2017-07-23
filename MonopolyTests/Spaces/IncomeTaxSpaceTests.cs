using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly.Events;
using Monopoly.Spaces;
using Moq;

namespace MonopolyTests.Spaces
{
    [TestClass]
    public class IncomeTaxSpaceTests
    {
        private Mock<INopEvent> mockNopEvent;
        private Mock<IIncomeTaxEvent> mockIncomeTaxEvent;
        private IncomeTaxSpace incomeTaxSpace;

        public IncomeTaxSpaceTests()
        {
            mockNopEvent = new Mock<INopEvent>();
            mockIncomeTaxEvent = new Mock<IIncomeTaxEvent>();
            incomeTaxSpace = new IncomeTaxSpace(mockNopEvent.Object, mockIncomeTaxEvent.Object);
        }

        [TestMethod]
        public void ConstructorInitializesEnterSpaceEventToNopEvent()
        {
            Assert.AreEqual(mockNopEvent.Object, incomeTaxSpace.EnterSpaceEvent);
        }

        [TestMethod]
        public void ConstructorInitializesLandOnSpaceEventToGoToJailEvent()
        {
            Assert.AreEqual(mockIncomeTaxEvent.Object, incomeTaxSpace.LandOnSpaceEvent);
        }
    }
}
