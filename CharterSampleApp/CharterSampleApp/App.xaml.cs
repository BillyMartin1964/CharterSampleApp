using CharterSampleApp.Services;
using CharterSampleApp.Views;

using System;
using CharterSampleApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CharterSampleApp
{
    public partial class App : Application
    {
        public static BillingStatement SelectedBillingStatement;
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            Routing.RegisterRoute("billingdetailpage", typeof(BillingDetailPage));
            Routing.RegisterRoute("settings", typeof(SettingsPage));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
