using CustomerManagementTest.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerManagementTest.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameValid()
        {
            //-- Arrange
            var customer = new Customer();
            customer.FirstName = "aaa";
            customer.LastName = "bbb";

            string expected = "bbb, aaa";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            var customer = new Customer();
            customer.FirstName = "aaa";

            string expected = "aaa";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            var customer = new Customer();
            customer.LastName = "bbb";

            string expected = "bbb";

            //-- Act
            string actual = customer.FullName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void StaticTest()
        {
            //-- Arrange
            var c1 = new Customer();
            c1.FirstName = "aaa";
            Customer.InstanceCount += 1;
            var c2 = new Customer();
            c2.FirstName = "bbb";
            Customer.InstanceCount += 1;
            var c3 = new Customer();
            c3.FirstName = "ccc";
            Customer.InstanceCount += 1;

            //-- Act

            //-- Assert
            Assert.AreEqual(3, Customer.InstanceCount);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //-- Arrange
            var customer = new Customer();
            customer.LastName = "bbb";
            customer.EmailAddress = "xxx@yyy.com";

            var expected = true;

            //-- Act
            var actual = customer.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingLastName()
        {
            //-- Arrange
            var customer = new Customer();
            customer.EmailAddress = "xxx@yyy.com";

            var expected = false;

            //-- Act
            var actual = customer.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
