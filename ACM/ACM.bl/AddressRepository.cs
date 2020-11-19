using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.bl
{
    public class AddressRepository
    {
        //retrieve one product
        public Address Retrieve(int addressId)
        {
            //instance of the product class
            Address address = new Address(addressId);

            //code that retrieves the defined product
            if (addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "nai bazar";
                address.StreetLine2 = "jaunpur";
                address.City = "Mungra";
                address.State = "uttar pradesh";
                address.Country = "India";
                address.Postalcode = "222202";
                
                
            }
            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1,
                StreetLine1 = "nai bazar",
                StreetLine2 = "jaunpur",
                City = "Mungra",
                State = "uttar pradesh",
                Country = "India",
                Postalcode = "222202"
            };
            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2,
                StreetLine1 = "bahur",
                StreetLine2 = "badlapur",
                City = "jaunpur",
                State = "uttar pradesh",
                Country = "India",
                Postalcode = "222175"
            };
            addressList.Add(address);

            return addressList;
        }
        //save the current product
        public bool save(Product product)
        {
            return true;
        }
    }
}
