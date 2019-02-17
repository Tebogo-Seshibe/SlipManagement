using NUnit.Framework;
using SlipManagementTests.Attributes;
using Tests;

namespace SlipManagementTests.Fixtures
{
    [TestFixture]
    [EmployeeCategory]
    public class EmployeeTest : Setup
    {
        [Test]
        [ReadCategory]
        public void GetAllEmployees()
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
