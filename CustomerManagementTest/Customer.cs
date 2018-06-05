using CustomerManagementTest.Common;
using System.Collections.Generic;

namespace CustomerManagementTest.BL
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer() : this(0)
        {

        }

        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }

        private string _lastName;

        public static int InstanceCount { get; set; }
        public int CustomerType { get; set; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string FirstName { get; set; }
        public List<Address> AddressList { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public override string ToString()
        {
            return FullName;
        }

        public string Log()
        {
            var logString = CustomerId + ": " +
                            FullName + " " +
                            "Email: " + EmailAddress;

            return logString;
        }

        /// <summary>
        /// Validates Customer's last name and email address
        /// </summary>
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
