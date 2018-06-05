namespace CustomerManagementTest.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }

        public int OrderItemId { get; set; }
        public int OrderQuantity { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Retrieves OrderItem by ID
        /// </summary>
        /// <param name="orderItemId"></param>
        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        /// <summary>
        /// Saves OrderItem to the DB
        /// </summary>
        public bool Save()
        {
            return true;
        }

        /// <summary>
        /// Validates OrderItem's quantity, ID and purchase price
        /// </summary>
        public bool Validate()
        {
            var isValid = true;

            if (OrderQuantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
