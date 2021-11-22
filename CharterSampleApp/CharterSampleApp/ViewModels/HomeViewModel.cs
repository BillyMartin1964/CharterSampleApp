using System;
using System.Windows.Input;

using Xamarin.Essentials;
using Xamarin.Forms;

namespace CharterSampleApp.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public HomeViewModel()
        {
            GetLocation();
        }

        private void GetLocation()
        {
            AvailableInText = "Now available in your area";
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

        private double latitude;
      
    }
}