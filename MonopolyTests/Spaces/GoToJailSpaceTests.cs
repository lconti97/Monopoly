using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly.CommandFactories;
using Monopoly.Spaces;
using Moq;

namespace MonopolyTests.Spaces
{
    [TestClass]
    public class GoToJailSpaceTests
    {
        private Mock<INullCommandFactory> mockNopCommandFactory;
        private Mock<IGoToJailCommandFactory> mockGoToJailCommandFactory;
        private GoToJailSpace goToJailSpace;

        public GoToJailSpaceTests()
        {
            mockNopCommandFactory = new Mock<INullCommandFactory>();
            mockGoToJailCommandFactory = new Mock<IGoToJailCommandFactory>();
            goToJailSpace = new GoToJailSpace(mockNopCommandFactory.Object, mockGoToJailCommandFactory.Object);
        }

        [TestMethod]
        public void ConstructorInitializesEnterSpaceCommandFactoryToNopCommandFactory()
        {
            Assert.AreEqual(mockNopCommandFactory.Object, goToJailSpace.EnterSpaceCommandFactory);
        }

        [TestMethod]
        public void ConstructorInitializesLandOnSpaceCommandFactoryToGoToJailCommandFactory()
        {
            Assert.AreEqual(mockGoToJailCommandFactory.Object, goToJailSpace.LandOnSpaceCommandFactory);
        }
    }
}
