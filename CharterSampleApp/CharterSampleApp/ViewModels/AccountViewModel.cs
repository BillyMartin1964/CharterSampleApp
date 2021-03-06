using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Input;

using CharterSampleApp.ContentViews;
using CharterSampleApp.Extensions;
using CharterSampleApp.Helpers;
using CharterSampleApp.Models;
using CharterSampleApp.Services;

using Xamarin.Essentials;
using Xamarin.Forms;

namespace CharterSampleApp.ViewModels
{
    public class AccountViewModel : BaseViewModel
    {

        public AccountViewModel()
        {
            GetCurrentSignedInUser();
        }

        private void GetCurrentSignedInUser()
        {
            if (App.UserSignedIn)
            {
                // Only show Account data to signed-in user
                CurrentUserAccount = _Repository.GetCurrentUserAccount(); 
            }
        }
    }
}