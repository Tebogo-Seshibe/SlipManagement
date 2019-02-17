using NUnit.Framework;

namespace Tests
{
    [SetUpFixture]
    public class Setup
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {

        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {

        }
    }
}