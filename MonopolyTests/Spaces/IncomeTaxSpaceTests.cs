using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly.CommandFactories;
using Monopoly.Spaces;
using Moq;

namespace MonopolyTests.Spaces
{
    [TestClass]
    public class IncomeTaxSpaceTests
    {
        private Mock<INullCommandFactory> mockNopCommandFactory;
        private Mock<IIncomeTaxCommandFactory> mockIncomeTaxCommandFactory;
        private IncomeTaxSpace incomeTaxSpace;

        public IncomeTaxSpaceTests()
        {
            mockNopCommandFactory = new Mock<INullCommandFactory>();
            mockIncomeTaxCommandFactory = new Mock<IIncomeTaxCommandFactory>();
            incomeTaxSpace = new IncomeTaxSpace(mockNopCommandFactory.Object, mockIncomeTaxCommandFactory.Object);
        }

        [TestMethod]
        public void ConstructorInitializesEnterSpaceCommandFactoryToNopCommandFactory()
        {
            Assert.AreEqual(mockNopCommandFactory.Object, incomeTaxSpace.EnterSpaceCommandFactory);
        }

        [TestMethod]
        public void ConstructorInitializesLandOnSpaceCommandFactoryToGoToJailCommandFactory()
        {
            Assert.AreEqual(mockIncomeTaxCommandFactory.Object, incomeTaxSpace.LandOnSpaceCommandFactory);
        }
    }
}
