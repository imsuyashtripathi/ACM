using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.bl
{
    public class Customer :EntityBase,ILoggable
    { 
        public Customer() :this(0)
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }
        public List<Address> AddressList { get; set; }
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public String EmailAddress { get; set; }


        public String FirstName { get; set; }
        public String FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(FullName))
                    {
                        fullName += ",";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
         
        public static int InstanceCount { get; set; }

        private string _LastName;
        public int customerId;

        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                _LastName = value;
            }

        }

        public string Log() => $"{CustomerId} :{FullName}Email: {EmailAddress} Status:{EntityState.ToString()}";

        public override string ToString() => FullName;

        // Validate Customer data
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }
    }
}
