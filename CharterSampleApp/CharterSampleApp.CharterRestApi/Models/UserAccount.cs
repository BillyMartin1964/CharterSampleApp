namespace CharterSampleApp.CharterRestApi.Models
{
    public class UserAccount
    {
        public int UserAccountId { get; set; }
        public string AccountNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public Address ServiceAddress { get; set; }
        public Address BillingAddress { get; set; }

        public UserAccount()
        {
            ServiceAddress = new Address();
            BillingAddress = new Address();
        }

    }
}
