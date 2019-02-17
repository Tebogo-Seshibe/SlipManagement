using NUnit.Framework;
using SlipManagementTests.Attributes;
using Tests;

namespace SlipManagementTests.Fixtures
{
    [TestFixture]
    [SlipCategory]
    public class SlipTest : Setup
    {
        [Test]
        [ReadCategory]
        public void GetAllSlips()
        {
            Assert.IsTrue(true);
        }

        [Test]
        [ReadCategory]
        [TestCase(1)]
        public void GetSlipById(int id)
        {
            Assert.IsTrue(true);
        }
    }
}
