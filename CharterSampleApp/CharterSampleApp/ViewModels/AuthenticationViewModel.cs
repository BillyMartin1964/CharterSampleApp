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

        private ContentView authenticationCV;
        public ContentView AuthenticationCV
        {
            get { return authenticationCV; }
            set
            {
                authenticationCV = value;
                OnPropertyChanged();
            }
        }


        #region Registration

        private ICommand registerUserCommand;
        public ICommand RegisterUserCommand =>
            registerUserCommand ??
            (registerUserCommand = new Command(async async => await ExecuteRegisterUserCommand()));

        private async Task ExecuteRegisterUserCommand()
        {
            // Save Registered User, then switch to sign-in form
            var registrationSuccessful = _Repository.RegisterNewUser();

            if (registrationSuccessful)
            {
                AuthenticationCV = new SignInForm();
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Registration Unsuccessful", "Please try again or contact customer support.", "OK");
            }
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

        #endregion

        #region Sign In 

        

        private ICommand signInCommand;
        public ICommand SignInCommand =>
            signInCommand ??
            (signInCommand = new Command(ExecuteSignInCommand));

        private void ExecuteSignInCommand()
        {
            UserLoggedIn = _Repository.GetSignInStatus();

            Application.Current.MainPage = new AppShell();
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


        #endregion

    }
}
