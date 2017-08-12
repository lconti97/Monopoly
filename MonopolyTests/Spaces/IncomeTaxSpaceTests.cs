using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly.Commands;
using Monopoly.Spaces;
using Moq;

namespace MonopolyTests.Spaces
{
    [TestClass]
    public class IncomeTaxSpaceTests
    {
        private Mock<INullCommand> mockNopCommand;
        private Mock<IIncomeTaxCommand> mockIncomeTaxCommand;
        private IncomeTaxSpace incomeTaxSpace;

        public IncomeTaxSpaceTests()
        {
            mockNopCommand = new Mock<INullCommand>();
            mockIncomeTaxCommand = new Mock<IIncomeTaxCommand>();
            incomeTaxSpace = new IncomeTaxSpace(mockNopCommand.Object, mockIncomeTaxCommand.Object);
        }

        [TestMethod]
        public void ConstructorInitializesEnterSpaceCommandToNopCommand()
        {
            Assert.AreEqual(mockNopCommand.Object, incomeTaxSpace.EnterSpaceCommand);
        }

        [TestMethod]
        public void ConstructorInitializesLandOnSpaceCommandToGoToJailCommand()
        {
            Assert.AreEqual(mockIncomeTaxCommand.Object, incomeTaxSpace.LandOnSpaceCommand);
        }
    }
}
