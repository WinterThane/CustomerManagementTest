using System;
using System.Text;
using CustomerManagementTest.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomerManagementTest.BLTest
{
    /// <summary>
    /// Summary description for ProductTest
    /// </summary>
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void CurrentPriceValid()
        {
            //-- Arrange
            var product = new Product();
            product.CurrentPrice = 100;

            Decimal expected = 100;

            //-- Act
            Decimal? actual = product.CurrentPrice;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductDescriptionValid()
        {
            //-- Arrange
            var product = new Product();
            product.ProductDescription = "aaa";

            string expected = "aaa";

            //-- Act
            string actual = product.ProductDescription;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ProductNameValid()
        {
            //-- Arrange
            var product = new Product();
            product.ProductName = "bbb";

            string expected = "bbb";

            //-- Act
            string actual = product.ProductName;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateValid()
        {
            //-- Arrange
            var product = new Product();
            product.ProductName = "xxx";
            product.CurrentPrice = 500;

            var expected = true;

            //-- Act
            var actual = product.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateMissingCurrentPrice()
        {
            //-- Arrange
            var product = new Product();
            product.ProductName = "xxx";

            var expected = false;

            //-- Act
            var actual = product.Validate();

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
