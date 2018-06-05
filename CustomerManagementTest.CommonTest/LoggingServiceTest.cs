using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerManagementTest.Common;
using CustomerManagementTest.BL;

namespace CustomerManagementTest.CommonTest
{
    /// <summary>
    /// Summary description for LoggingService
    /// </summary>
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //-- Arrange 
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "aaa@bbb.com",
                FirstName = "aaa",
                LastName = "bbb",
                AddressList = null
            };
            changedItems.Add(customer as ILoggable);

            var product = new Product()
            {
                ProductName = "Rake",
                ProductDescription = "xxx",
                CurrentPrice = 6M
            };
            changedItems.Add(product as ILoggable);

            //-- Act
            LoggingService.WriteToFile(changedItems);

            //-- Assert
        }
    }
}
