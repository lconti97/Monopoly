using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly.Commands;

namespace MonopolyTests.Commands
{
    [TestClass]
    public class NopCommandTests
    {
        private NullCommand nullCommand;

        public NopCommandTests()
        {
            nullCommand = new NullCommand();
        }

        [TestMethod]
        public void ActIsImplemented()
        {
            nullCommand.Execute();
        }
    }
}
