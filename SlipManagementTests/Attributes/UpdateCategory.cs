using NUnit.Framework;

namespace SlipManagementTests.Attributes
{
    public class UpdateCategory : CategoryAttribute
    {
        public UpdateCategory() : base("Update") { }
    }
}
