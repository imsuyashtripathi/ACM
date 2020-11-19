using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.bl
{
    public class Address
    {
        public Address()
        {

        }
        public Address(int addressId)
        {
            AddressId = addressId;
        }

        public int AddressId { get; set; }
        public int AddressType { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Postalcode { get; set; }
        public string State { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }

        // Validate address data
        public bool Validate()
        {
            var isValid = true;
            if (Postalcode == null) isValid = false;

            return isValid;
        }
    }
}
