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

    }
}