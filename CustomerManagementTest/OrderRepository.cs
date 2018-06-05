using System;
using System.Collections.Generic;

namespace CustomerManagementTest.BL
{
    public class OrderRepository
    {
        /// <summary>
        /// Retrieves Order by ID
        /// </summary>
        /// <param name="orderId"></param>
        public Order Retrieve(int orderId)
        {
            var order = new Order();

            if(orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
            }

            return new Order();
        }

        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            var orderDisplay = new OrderDisplay();

            if(orderId == 10)
            {
                orderDisplay.FirstName = "aaa";
                orderDisplay.LastName = "bbb";
                orderDisplay.OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
                orderDisplay.ShippingAddress = new Address()
                {
                    AddressType = 1,
                    StreetLine1 = "street 1",
                    StreetLine2 = "street 2",
                    City = "city",
                    State = "state",
                    Country = "country",
                    PostalCode = "8250"
                };
            }

            orderDisplay.OrderDisplayItemList = new List<OrderDisplayItem>();

            if(orderId == 10)
            {
                var orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "aaa",
                    PurchasePrice = 10.12M,
                    OrderQuantity = 5
                };
                orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);

                orderDisplayItem = new OrderDisplayItem()
                {
                    ProductName = "bbb",
                    PurchasePrice = 2.2M,
                    OrderQuantity = 50
                };
                orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);
            }

            return orderDisplay;
        }

        /// <summary>
        /// Saves Order to the DB
        /// </summary>
        public bool Save()
        {
            return true;
        }
    }
}
