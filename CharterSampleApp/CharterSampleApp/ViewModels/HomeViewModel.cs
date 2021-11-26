using System;
using System.Threading.Tasks;
using System.Windows.Input;

using CharterSampleApp.Views;

using Xamarin.Essentials;
using Xamarin.Forms;

namespace CharterSampleApp.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            GetLocation();

            AssignLanguageFlag();
        }

        private void GetLocation()
        {
            // Add gps call here
            Random randomNumber = new Random();

            bool isAvailableInArea = Convert.ToBoolean(randomNumber.Next(2));

            if (isAvailableInArea)
            {
                AvailableInText = "Now available in your area";
            }
            else
            {
                AvailableInText = "Coming soon to your area";
            }
        }

        private string availableInText;
        public string AvailableInText
        {
            get { return availableInText; }
            set
            {
                availableInText = value;
                OnPropertyChanged();
            }
        }

        private ICommand _openSettingsCommand;
        public ICommand OpenSettingsCommand =>
            _openSettingsCommand ??
            (_openSettingsCommand = new Command(async () => await ExecuteOpenSettingsCommand()));

        private async Task ExecuteOpenSettingsCommand()
        {
          //  App.Current.MainPage = new NavigationPage(new SettingsPage());

            await App.Current.MainPage.Navigation.PushModalAsync(new SettingsPage(), true);
        }
    }
}