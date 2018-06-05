using CustomerManagementTest.BL;

namespace CustomerManagementTest
{
    public class ProductRepository
    {
        /// <summary>
        /// Returns a product by ID
        /// </summary>
        /// <param name="productId">ID</param>
        public Product Retrieve(int productId)
        {
            var product = new Product(productId);

            if(productId == 2)
            {
                product.ProductName = "test";
                product.ProductDescription = "aaa";
                product.CurrentPrice = 15.33M;
            }

            return product;
        }

        /// <summary>
        /// Saves a product to the DB
        /// </summary>
        public bool Save(Product product)
        {
            var success = true;

            if(product.HasChanges && product.IsValid)
            {
                if(product.IsNew)
                {
                    //insert
                }
                else
                {
                    //update
                }
            }

            return success;
        }
    }
}
