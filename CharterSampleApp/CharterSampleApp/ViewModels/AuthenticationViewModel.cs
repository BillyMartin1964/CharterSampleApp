using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

using CharterSampleApp.ContentViews;
using CharterSampleApp.Views;
using Xamarin.Forms;

namespace CharterSampleApp.ViewModels
{
    public class AuthenticationViewModel : BaseViewModel
    {
        public AuthenticationViewModel()
        {
            AuthenticationCV = new SignInForm();
        }

        private ICommand showRegisterFormCommand;

        public ICommand SignInRegisterFormCommand =>
            showRegisterFormCommand ??
            (showRegisterFormCommand = new Command(ExecuteShowRegisterFormCommand));

        private void ExecuteShowRegisterFormCommand(object obj)
        {
            switch (obj)
            {
                case "register":
                    AuthenticationCV = new RegisterForm();
                    break;

                case "sign in":
                    AuthenticationCV = new SignInForm();
                    break;
            }
        }

        private ICommand cancelCommand;

        public ICommand CancelCommand =>
            cancelCommand ??
            (cancelCommand = new Command(async () => await ExecuteCancelCommand()));

        private async Task ExecuteCancelCommand()
        {
            App.UserSignedIn = false;

            await App.Current.MainPage.Navigation.PushModalAsync(new HomePage(), true);
        }
    }
}
