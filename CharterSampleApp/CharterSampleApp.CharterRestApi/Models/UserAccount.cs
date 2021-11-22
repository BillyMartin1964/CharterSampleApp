using System.ComponentModel.DataAnnotations;

namespace CharterSampleApp.CharterRestApi.Models
{
    public class UserAccount
    {
        [Key]
        public int AccountNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public Address ServiceAddress { get; set; }
        public Address BillingAddress { get; set; }

        public UserAccount()
        {
            ServiceAddress = new Address();
            BillingAddress = new Address();
        }

    }
}
