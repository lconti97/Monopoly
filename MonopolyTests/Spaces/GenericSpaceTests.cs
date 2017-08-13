using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly.CommandFactories;
using Monopoly.Spaces;
using Moq;

namespace MonopolyTests.Spaces
{
    [TestClass]
    public class GenericSpaceTests
    {
        private Mock<INullCommandFactory> mockNopCommandFactory1;
        private Mock<INullCommandFactory> mockNopCommandFactory2;
        private GenericSpace genericSpace;

        public GenericSpaceTests()
        {
            mockNopCommandFactory1 = new Mock<INullCommandFactory>();
            mockNopCommandFactory2 = new Mock<INullCommandFactory>();
            genericSpace = new GenericSpace(mockNopCommandFactory1.Object, mockNopCommandFactory2.Object);
        }

        [TestMethod]
        public void ConstructorInitializesEnterSpaceCommandFactoryToNopCommandFactory()
        {
            Assert.AreEqual(mockNopCommandFactory1.Object, genericSpace.EnterSpaceCommandFactory);
        }

        [TestMethod]
        public void ConstructorInitializesLandOnSpaceCommandFactoryToNopCommandFactory()
        {
            Assert.AreEqual(mockNopCommandFactory2.Object, genericSpace.LandOnSpaceCommandFactory);
        }
    }
}
