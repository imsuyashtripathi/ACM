using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.bl
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        private AddressRepository addressRepository { get; set; }
        //Retrieve one customer
        public Customer Retrieve(int customerId)
        {
            //instance of customer
            Customer customer = new Customer();

            if (customerId == 1)
            {
                customer.EmailAddress = "suyashtripathi98@gmail.com";
                customer.FirstName = "Suyash";
                customer.LastName = "Tripathi";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }
        //sve the current customer
        public bool Save(Customer customer)
        {
            return true;
        }

    }
}
