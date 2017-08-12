using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly.Commands;
using Monopoly.Spaces;
using Moq;

namespace MonopolyTests.Spaces
{
    [TestClass]
    public class GoToJailSpaceTests
    {
        private Mock<INullCommand> mockNopCommand;
        private Mock<IGoToJailCommand> mockGoToJailCommand;
        private GoToJailSpace goToJailSpace;

        public GoToJailSpaceTests()
        {
            mockNopCommand = new Mock<INullCommand>();
            mockGoToJailCommand = new Mock<IGoToJailCommand>();
            goToJailSpace = new GoToJailSpace(mockNopCommand.Object, mockGoToJailCommand.Object);
        }

        [TestMethod]
        public void ConstructorInitializesEnterSpaceCommandToNopCommand()
        {
            Assert.AreEqual(mockNopCommand.Object, goToJailSpace.EnterSpaceCommand);
        }

        [TestMethod]
        public void ConstructorInitializesLandOnSpaceCommandToGoToJailCommand()
        {
            Assert.AreEqual(mockGoToJailCommand.Object, goToJailSpace.LandOnSpaceCommand);
        }
    }
}
