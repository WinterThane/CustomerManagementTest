using CustomerManagementTest.Common;
using System;
using System.Collections.Generic;

namespace CustomerManagementTest.BL
{
    public class Order : EntityBase, ILoggable
    {
        public Order()
        {

        }

        public Order(int orderId)
        {
            OrderId = orderId;
        }

        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public List<OrderItem> OrderItems { get; set; }

        public override string ToString()
        {
            return OrderDate.Value.Date + " (" + OrderId + ")";
        }

        public string Log()
        {
            var logString = OrderId + ": " +
                            "Date: " + OrderDate.Value.Date;

            return logString;
        }

        /// <summary>
        /// Validates Order's order date
        /// </summary>
        public override bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
