using System;
using System.Windows.Input;
using CharterSampleApp.Interfaces;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CharterSampleApp.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {
        public SettingsViewModel()
        {
            
        }

        private ICommand openDeviceSettings;
        public ICommand OpenDeviceSettings =>
            openDeviceSettings ??
            (openDeviceSettings = new Command(ExecuteOpenDeviceSettings));

        private void ExecuteOpenDeviceSettings(object obj)
        {
           DependencyService.Get<ITakeUserToAppSettings>().GoToAppSettings();
        }
    }
}