
using DataVerification.DataModels;
using log4net;
using NUnit.Framework;
using NUnit.Framework.Internal;
using NUnit.Framework.Legacy;
using UiHelpers;
using UiUtilities.Log4Net;
namespace DataVerification
{
    [TestFixture]
    public class DataVerificationTest
    {
        private readonly ILog _logger;
        public DataVerificationTest() 
        {
            _logger =  new TestLogger<DataVerificationTest>().TestLog4Net();
        }
        [Test]
        public void TestObjectEquality()
        {
            _logger.Info("Test Object Equality Method");
            ObjectComparison<Person> objectComparison = new();
            _logger.Debug("Debuging Test Object Equality Method");
            // Create Person objects
            Person person1 = new (){ FirstName = "Johil", LastName = "Angelo" };
            Person person2 = new() { FirstName = "Johil", LastName = "Angelo" };
            Person person3 = new() { FirstName = "John", LastName = "Angelo" };
            // Test object equality
            ClassicAssert.IsTrue(objectComparison.AreEqual(person1, person2), "Objects should be equal");
            ClassicAssert.IsFalse(objectComparison.AreEqual(person1, person3), "Objects should not be equal");
            _logger.Warn("Test Object Equality Method Is completed");
        }
    }
}
