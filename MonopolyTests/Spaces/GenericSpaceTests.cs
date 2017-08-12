using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly.Commands;
using Monopoly.Spaces;
using Moq;

namespace MonopolyTests.Spaces
{
    [TestClass]
    public class GenericSpaceTests
    {
        private Mock<INullCommand> mockNopCommand1;
        private Mock<INullCommand> mockNopCommand2;
        private GenericSpace genericSpace;

        public GenericSpaceTests()
        {
            mockNopCommand1 = new Mock<INullCommand>();
            mockNopCommand2 = new Mock<INullCommand>();
            genericSpace = new GenericSpace(mockNopCommand1.Object, mockNopCommand2.Object);
        }

        [TestMethod]
        public void ConstructorInitializesEnterSpaceCommandToNopCommand()
        {
            Assert.AreEqual(mockNopCommand1.Object, genericSpace.EnterSpaceCommand);
        }

        [TestMethod]
        public void ConstructorInitializesLandOnSpaceCommandToNopCommand()
        {
            Assert.AreEqual(mockNopCommand2.Object, genericSpace.LandOnSpaceCommand);
        }
    }
}
