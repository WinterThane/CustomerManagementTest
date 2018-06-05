using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerManagementTest.BL;
using System.Collections.Generic;

namespace CustomerManagementTest.BLTest
{
    /// <summary>
    /// Summary description for CustomerRepositoryTest
    /// </summary>
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveExisting()
        {
            //-- Arrange
            var customerRepo = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "aaa@bbb.com",
                FirstName = "aaa",
                LastName = "bbb"
            };

            //-- Act
            var actual = customerRepo.Retrieve(1);

            //-- Assert
            //Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
        }

        [TestMethod]
        public void RetrieveExistingWithAddress()
        {
            //-- Arrange
            var customerRepo = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "aaa@bbb.com",
                FirstName = "aaa",
                LastName = "bbb",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                        AddressType = 1,
                        StreetLine1 = "street 1",
                        StreetLine2 = "street 2",
                        City = "city",
                        State = "state",
                        Country = "country",
                        PostalCode = "8250"
                    },
                    new Address()
                    {
                        AddressType = 2,
                        StreetLine1 = "street 11",
                        StreetLine2 = "street 22",
                        City = "city2",
                        State = "state2",
                        Country = "country2",
                        PostalCode = "82502"
                    }
                }
            };

            //-- Act
            var actual = customerRepo.Retrieve(1);

            //-- Assert
            //Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].StreetLine2, actual.AddressList[i].StreetLine2);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }
    }
}
