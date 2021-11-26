using System;
using System.Windows.Input;
using CharterSampleApp.Interfaces;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CharterSampleApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            GetAppVersion();
        }

        private void GetAppVersion()
        {
            // Use Dependency Service to get the platform's app version
            AppVersion = $"Spectrum Sample App Version: {DependencyService.Get<IGetAppVersion>().GetAppVersion()}";
        }

        private string appVersion;
        public string AppVersion            
        {
            get { return appVersion; }
            set
            {
                appVersion = value;
                OnPropertyChanged();
            }
        }
      
    }
}