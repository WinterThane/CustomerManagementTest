using System;
using CustomerManagementTest.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerManagementTest.BLTest
{
    /// <summary>
    /// Summary description for OrderItemTest
    /// </summary>
    [TestClass]
    public class OrderItemTest
    {
        [TestMethod]
        public void OrderQuantityValid()
        {
            //-- Arrange
            var oi = new OrderItem();
            oi.OrderQuantity = 100;

            int expected = 100;

            //-- Act
            int actual = oi.OrderQuantity;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PurchasePriceValid()
        {
            //-- Arrange
            var oi = new OrderItem();
            oi.PurchasePrice = 500;

            decimal expected = 500;

            //-- Act
            decimal? actual = oi.PurchasePrice;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //-- Arrange
            var oi = new OrderItem();
            oi.OrderQuantity = 10;
            oi.ProductId = 5;
            oi.PurchasePrice = 500;
            
            var expected = true;

            //-- Act
            var actual = oi.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingPurchasePrice()
        {
            //-- Arrange
            var oi = new OrderItem();
            oi.OrderQuantity = 10;
            oi.ProductId = 5;

            var expected = false;

            //-- Act
            var actual = oi.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
