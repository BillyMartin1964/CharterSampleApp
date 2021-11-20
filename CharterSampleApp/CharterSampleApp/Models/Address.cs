using System;
using System.Collections.Generic;
using System.Text;

namespace CharterSampleApp.Models
{
    public class Address
    {
        public string StreetAddress { get; set; }
        public string City { get; set; } 
        public string State { get; set; }
        public string ZipCode { get; set; }

        public Address()
        {
            StreetAddress = "56789 Cross St.";
            City = "AnyTown";
            State = "Co";
            ZipCode = "55555";
        }
    }
}
