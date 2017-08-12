using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly.Commands;
using Monopoly.Spaces;
using Moq;

namespace MonopolyTests.Spaces
{
    [TestClass]
    public class GoSpaceTests
    {
        private Mock<IPassGoCommand> mockPassGoCommand;
        private Mock<INullCommand> mockNopCommand;
        private GoSpace goSpace;

        public GoSpaceTests()
        {
            mockPassGoCommand = new Mock<IPassGoCommand>();
            mockNopCommand = new Mock<INullCommand>();
            goSpace = new GoSpace(mockPassGoCommand.Object, mockNopCommand.Object);
        }

        [TestMethod]
        public void ConstructorInitializesEnterSpaceCommandToNewPassGoCommand()
        {
            Assert.AreEqual(mockPassGoCommand.Object, goSpace.EnterSpaceCommand);
        }

        [TestMethod]
        public void ConstructorInitializesLandOnSpaceCommandToNewNopCommand()
        {
            Assert.AreEqual(mockNopCommand.Object, goSpace.LandOnSpaceCommand);
        }
    }
}
