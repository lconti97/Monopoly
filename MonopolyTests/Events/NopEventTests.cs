using Microsoft.VisualStudio.TestTools.UnitTesting;
using Monopoly.Events;

namespace MonopolyTests.Events
{
    [TestClass]
    public class NopEventTests
    {
        private NopEvent nopEvent;

        public NopEventTests()
        {
            nopEvent = new NopEvent();
        }

        [TestMethod]
        public void ActIsImplemented()
        {
            nopEvent.Act(null, null);
        }
    }
}
