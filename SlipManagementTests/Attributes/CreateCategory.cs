using NUnit.Framework;

namespace SlipManagementTests.Attributes
{
    public class CreateCategory : CategoryAttribute
    {
        public CreateCategory() : base("Create") { }
    }
}
