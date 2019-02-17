using NUnit.Framework;

namespace SlipManagementTests.Attributes
{
    public class EmployeeCategory : CategoryAttribute
    {
        public EmployeeCategory() : base("Employee") { }
    }
}
