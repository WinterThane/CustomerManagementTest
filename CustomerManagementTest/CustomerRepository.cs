using System.Collections.Generic;
using System.Linq;

namespace CustomerManagementTest.BL
{
    public class CustomerRepository
    {
        private AddressRepository AddressRepository { get; set; }

        public CustomerRepository()
        {
            AddressRepository = new AddressRepository();
        }

        /// <summary>
        /// Retrieves a Customer by ID
        /// </summary>
        /// <param name="customer"></param>
        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId);
            customer.AddressList = AddressRepository.RetrieveByCustomerId(customerId).ToList();

            if(customerId == 1)
            {
                customer.EmailAddress = "aaa@bbb.com";
                customer.FirstName = "aaa";
                customer.LastName = "bbb";
            }

            return customer;
        }

        /// <summary>
        /// Retrieves all Customers
        /// </summary>
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        /// <summary>
        /// Saves a Customer to the DB
        /// </summary>
        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
