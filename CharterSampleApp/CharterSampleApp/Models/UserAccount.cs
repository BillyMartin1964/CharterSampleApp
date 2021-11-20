using System;
using System.Collections.Generic;
using System.Text;

namespace CharterSampleApp.Models
{
    public class UserAccount
    {
        public string AccountNumber { get; set; } = "123456789";
        public string FirstName { get; set; } = "Billy";
        public string LastName { get; set; } = "Martin";
        public string PhoneNumber { get; set; } = "(810) 640-5877";
        public string EmailAddress { get; set; } = "william.martin1964@outlook.com";

        public Address ServiceAddress { get; set; }
        public Address BillingAddress { get; set; }

        public UserAccount()
        {
            ServiceAddress = new Address();
            BillingAddress = new Address();
        }

    }
}
