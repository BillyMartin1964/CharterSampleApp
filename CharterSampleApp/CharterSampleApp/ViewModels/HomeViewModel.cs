using System;
using System.Threading.Tasks;
using System.Windows.Input;

using CharterSampleApp.Resources;
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
            // Normally would add a gps call here:

            // Coin flip to see if Spectrum is available in area.
            Random randomNumber = new Random();

            // Bound bool will be sent to a convert to return the appropriate string response
            IsAvailableInArea = Convert.ToBoolean(randomNumber.Next(2));
        }

        private bool isAvailableInArea;
        public bool IsAvailableInArea
        {
            get { return isAvailableInArea; }
            set
            {
                isAvailableInArea = value;
                OnPropertyChanged();
            }
        }

        private ICommand _openSettingsCommand;
        public ICommand OpenSettingsCommand =>
            _openSettingsCommand ??
            (_openSettingsCommand = new Command(async () => await ExecuteOpenSettingsCommand()));

        private async Task ExecuteOpenSettingsCommand()
        {
            await App.Current.MainPage.Navigation.PushModalAsync(new SettingsPage(), true);
        }
    }
}