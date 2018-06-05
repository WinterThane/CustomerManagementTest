using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomerManagementTest.BL;

namespace CustomerManagementTest.BLTest
{
    /// <summary>
    /// Summary description for OrderRepositoryTest
    /// </summary>
    [TestClass]
    public class OrderRepositoryTest
    {
        [TestMethod]
        public void RetrieveOrderDisplayTest()
        {
            //-- Arrange
            var orderRepo = new OrderRepository();
            var expected = new OrderDisplay()
            {
                FirstName = "aaa",
                LastName = "bbb",
                OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0)),
                ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "street 1",
                    StreetLine2 = "street 2",
                    City = "city",
                    State = "state",
                    Country = "country",
                    PostalCode = "8250"
                },
                OrderDisplayItemList = new List<OrderDisplayItem>()
                {
                    new OrderDisplayItem()
                    {
                        ProductName = "aaa",
                        PurchasePrice = 10.12M,
                        OrderQuantity = 5
                    },
                    new OrderDisplayItem()
                    {
                        ProductName = "bbb",
                        PurchasePrice = 2.2M,
                        OrderQuantity = 50
                    }
                }
            };

            //-- Act
            var actual = orderRepo.RetrieveOrderDisplay(10);

            //-- Assert
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.OrderDate, actual.OrderDate);

            Assert.AreEqual(expected.ShippingAddress.AddressType, actual.ShippingAddress.AddressType);
            Assert.AreEqual(expected.ShippingAddress.StreetLine1, actual.ShippingAddress.StreetLine1);
            Assert.AreEqual(expected.ShippingAddress.StreetLine2, actual.ShippingAddress.StreetLine2);
            Assert.AreEqual(expected.ShippingAddress.City, actual.ShippingAddress.City);
            Assert.AreEqual(expected.ShippingAddress.State, actual.ShippingAddress.State);
            Assert.AreEqual(expected.ShippingAddress.Country, actual.ShippingAddress.Country);
            Assert.AreEqual(expected.ShippingAddress.PostalCode, actual.ShippingAddress.PostalCode);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.OrderDisplayItemList[i].OrderQuantity, actual.OrderDisplayItemList[i].OrderQuantity);
                Assert.AreEqual(expected.OrderDisplayItemList[i].ProductName, actual.OrderDisplayItemList[i].ProductName);
                Assert.AreEqual(expected.OrderDisplayItemList[i].PurchasePrice, actual.OrderDisplayItemList[i].PurchasePrice);
            }
        }
    }
}
