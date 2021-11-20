using System;
using System.Windows.Input;

using Xamarin.Essentials;
using Xamarin.Forms;

namespace CharterSampleApp.ViewModels
{
    public class BillingViewModel : BaseViewModel
    {
        public BillingViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}