using NUnit.Framework;

namespace PfProj.UnitTests
{
    [TestFixture(10)]
    [TestFixture(42)]
    public class DataDrivenTestFixture
    {
        [Test]
        public void IsNull()
        {
            object nada = null;

            // Constraint Syntax
            Assert.That(nada, Is.Null);
        }
    }
}