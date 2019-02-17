using NUnit.Framework;

namespace SlipManagementTests.Attributes
{
    public class DeleteCategory : CategoryAttribute
    {
        public DeleteCategory() : base("Delete") { }
    }
}
