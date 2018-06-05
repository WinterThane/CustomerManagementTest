using System;
using CustomerManagementTest.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerManagementTest.BLTest
{
    /// <summary>
    /// Summary description for OrderTest
    /// </summary>
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void OrderDateValid()
        {
            //-- Arrange
            var order = new Order();
            order.OrderDate = DateTimeOffset.Now;

            DateTimeOffset expected = DateTimeOffset.Now;

            //-- Act
            DateTimeOffset? actual = DateTimeOffset.Now;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //-- Arrange
            var order = new Order();
            order.OrderDate = DateTimeOffset.Now;

            var expected = true;

            //-- Act
            var actual = order.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingCurrentPrice()
        {
            //-- Arrange
            var order = new Order();

            var expected = false;

            //-- Act
            var actual = order.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
