using System.Collections.ObjectModel;

using CharterSampleApp.Models;

namespace CharterSampleApp.Services
{
    public interface IRepository
    {
        bool RegisterNewUser();
        bool GetSignInStatus();
        UserAccount GetCurrentUserAccount();
        ObservableCollection<BillingStatement> GetUserBillingStatements();
    }
}