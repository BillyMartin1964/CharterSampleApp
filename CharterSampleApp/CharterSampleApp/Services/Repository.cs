using System.Collections.ObjectModel;
using CharterSampleApp.Models;

namespace CharterSampleApp.Services
{
    public class Repository : IRepository
    {
        public Repository()
        {

        }

        public bool RegisterNewUser()
        {
            // Registration successful
            return true;
        }

        public bool GetSignInStatus()
        {
            App.UserSignedIn = true;
            return true;
        }

        public UserAccount GetCurrentUserAccount()
        {
            // Return fake data for demonstration purposes
            return DummyData.GetUserAccount();
        }

        public ObservableCollection<BillingStatement> GetUserBillingStatements()
        {
            // Return fake data for demonstration purposes
            return DummyData.GetDummyBillingData();
        }
    }
}
