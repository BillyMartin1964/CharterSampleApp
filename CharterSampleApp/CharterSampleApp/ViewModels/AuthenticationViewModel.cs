using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

using CharterSampleApp.ContentViews;

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

      

        //public void ToggleLoggedInTest()
        //{
        //    if (UserLoggedIn)
        //    {
        //        UserLoggedInMessage = "User Logged In";
        //        AccountCV = new AccountContentView();
        //    }
        //    else
        //    {
        //        UserLoggedInMessage = "User Logged Out";

        //        AccountCV = new SignInForm();
        //    }
        //}
    }
}
