using NUnit.Framework;

namespace SlipManagementTests.Attributes
{
    public class SlipCategory : CategoryAttribute
    {
        public SlipCategory() : base("Slip") { }
    }
}
