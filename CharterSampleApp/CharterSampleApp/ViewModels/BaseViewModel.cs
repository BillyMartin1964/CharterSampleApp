using CharterSampleApp.Models;
using CharterSampleApp.Services;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using CharterSampleApp.ContentViews;
using CharterSampleApp.Views;
using Xamarin.Forms;

namespace CharterSampleApp.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        //  public IDataStore<Item> DataStore => DependencyService.Get<IDataStore<Item>>();
        public IRepository _Repository => DependencyService.Get<IRepository>();

        public BaseViewModel()
        {
            CurrentUserAccount = new UserAccount();


        }

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

        string title = string.Empty;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion


        private object selectedItem;
        public object SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged();
            }
        }

        private UserAccount currentUserAccount;
        public UserAccount CurrentUserAccount
        {
            get { return currentUserAccount; }
            set
            {
                currentUserAccount = value;
                OnPropertyChanged();
            }
        }

        private bool userLoggedIn;
        public bool UserLoggedIn
        {
            get { return userLoggedIn; }
            set
            {
                userLoggedIn = value;
                App.UserSignedIn = value;
                OnPropertyChanged();
            }
        }

        private ICommand goToNewPageCommand;
        public ICommand GoToNewPageCommand =>
            goToNewPageCommand ??
            (goToNewPageCommand = new Command<string>(async (x) => await ExecuteGoToNewPageCommand(x)));

        private async Task ExecuteGoToNewPageCommand(string page)
        {
            await Shell.Current.GoToAsync(page);
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

        private ICommand navigateForSignInCommand;
        public ICommand NavigateForSignInCommand =>
            navigateForSignInCommand ??
            (navigateForSignInCommand = new Command(async () => await ExecuteNavigateForSignInCommand()));

        private async Task ExecuteNavigateForSignInCommand()
        {
            if (App.UserSignedIn)
            {
                App.UserSignedIn = false;

                await App.Current.MainPage.Navigation.PushModalAsync(new HomePage(), true);
            }
            else
            {
                await App.Current.MainPage.Navigation.PushModalAsync(new AuthenticationPage(), true);
            }

        }

        public void AssignLanguageFlag()
        {
           var tempFlag = string.Empty;

            var languageAbrev = Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;

            switch (languageAbrev)
            {
                case "en":
                    tempFlag = "america.png";
                    break;
                case "es":
                    tempFlag = "spain.png";
                    break;
                case "fr":
                    tempFlag = "france.png";
                    break;

                default:
                    tempFlag = "america.png";
                    break;
            }

            LanguageFlag = ImageSource.FromResource($"CharterSampleApp.UserInterface.Images.LanguageFlags.{tempFlag}");
        }

        private ImageSource languageFlag = null;
        public ImageSource LanguageFlag
        {
            get { return languageFlag; }
            set
            {
                languageFlag = value;
                OnPropertyChanged();
            }
        }
    }
}
