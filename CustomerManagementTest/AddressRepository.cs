using CustomerManagementTest.BL;
using System.Collections.Generic;

namespace CustomerManagementTest
{
    public class AddressRepository
    {
        /// <summary>
        /// Retrieve one address
        /// </summary>
        /// <param name="addressId"></param>
        public Address Retrieve(int addressId)
        {
            var address = new Address(addressId);

            if(addressId == 1)
            {
                address.StreetLine1 = "street 1";
                address.StreetLine2 = "street 2";
                address.City = "city";
                address.State = "state";
                address.Country = "country";
                address.PostalCode = "8250";
            }

            return address;
        }

        /// <summary>
        /// Returns a list of addresses
        /// </summary>
        /// <param name="customerId"></param>
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            var address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "street 1",
                StreetLine2 = "street 2",
                City = "city",
                State = "state",
                Country = "country",
                PostalCode = "8250"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "street 11",
                StreetLine2 = "street 22",
                City = "city2",
                State = "state2",
                Country = "country2",
                PostalCode = "82502"
            };
            addressList.Add(address);

            return addressList;
        }

        /// <summary>
        /// Saves the address to the DB
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }
    }
}
