using System;
using System.Windows.Input;

using CharterSampleApp.ContentViews;

using Xamarin.Essentials;
using Xamarin.Forms;

namespace CharterSampleApp.ViewModels
{
    public class AccountViewModel : BaseViewModel
    {
        public AccountViewModel()
        {
            ToggleLoggedInTest();
        }

        private ContentView accountCV;

        public ContentView AccountCV
        {
            get { return accountCV; }
            set
            {
                accountCV = value;
                OnPropertyChanged();
            }
        }

        private string userLoggedInMessage;
        public string UserLoggedInMessage
        {
            get { return userLoggedInMessage; }
            set
            {
                userLoggedInMessage = value;
                OnPropertyChanged();
            }
        }

        private Command showRegisterFormCommand;

        public ICommand SignInRegisterFormCommand
        {
            get
            {
                if (showRegisterFormCommand == null)
                {
                    showRegisterFormCommand = new Command(ExecuteShowRegisterFormCommand);
                }

                return showRegisterFormCommand;
            }
        }

        private void ExecuteShowRegisterFormCommand(object obj)
        {
            switch (obj)
            {
                case "register":
                    AccountCV = new RegisterForm();
                    break;

                case "sign in":
                    AccountCV = new SignInForm();
                    break;
            }
        }


        private Command toggleLoggedInCommand;

        public ICommand ToggleLoggedInCommand
        {
            get
            {
                if (toggleLoggedInCommand == null)
                {
                    toggleLoggedInCommand = new Command(ToggleLoggedIn);
                }

                return toggleLoggedInCommand;
            }
        }

        private void ToggleLoggedIn()
        {
            UserLoggedIn = !UserLoggedIn;

            ToggleLoggedInTest();
        }

        private void ToggleLoggedInTest()
        {
            if (UserLoggedIn)
            {
                UserLoggedInMessage = "User Logged In";
                AccountCV = new AccountContentView();
            }
            else
            {
                UserLoggedInMessage = "User Logged Out";

                AccountCV = new SignInForm();
            }
        }
    }
}