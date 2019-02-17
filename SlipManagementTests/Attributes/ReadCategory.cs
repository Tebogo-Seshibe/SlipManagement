using NUnit.Framework;

namespace SlipManagementTests.Attributes
{
    public class ReadCategory : CategoryAttribute
    {
        public ReadCategory() : base("Read") { }
    }
}
