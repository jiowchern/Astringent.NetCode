using NUnit.Framework;

namespace Astringent.Remote.UnitySources.TestProtocol.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
         
        }

        [Test]
        public void Test1()
        {
            var protocol = ProtocolProvider.CreateCase();
            Assert.AreNotEqual(null, protocol);
        }
    }
}