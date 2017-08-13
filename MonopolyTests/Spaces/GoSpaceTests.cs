using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly.CommandFactories;
using Monopoly.Spaces;
using Moq;

namespace MonopolyTests.Spaces
{
    [TestClass]
    public class GoSpaceTests
    {
        private Mock<IPassGoCommandFactory> mockPassGoCommandFactory;
        private Mock<INullCommandFactory> mockNopCommandFactory;
        private GoSpace goSpace;

        public GoSpaceTests()
        {
            mockPassGoCommandFactory = new Mock<IPassGoCommandFactory>();
            mockNopCommandFactory = new Mock<INullCommandFactory>();
            goSpace = new GoSpace(mockPassGoCommandFactory.Object, mockNopCommandFactory.Object);
        }

        [TestMethod]
        public void ConstructorInitializesEnterSpaceCommandFactoryToNewPassGoCommandFactory()
        {
            Assert.AreEqual(mockPassGoCommandFactory.Object, goSpace.EnterSpaceCommandFactory);
        }

        [TestMethod]
        public void ConstructorInitializesLandOnSpaceCommandFactoryToNewNopCommandFactory()
        {
            Assert.AreEqual(mockNopCommandFactory.Object, goSpace.LandOnSpaceCommandFactory);
        }
    }
}
