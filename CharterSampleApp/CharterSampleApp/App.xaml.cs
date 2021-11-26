using CharterSampleApp.Services;
using CharterSampleApp.Views;

using System;
using System.Globalization;
using CharterSampleApp.Models;
using CharterSampleApp.Resources;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CharterSampleApp
{
    public partial class App : Application
    {
        public static BillingStatement SelectedBillingStatement;
        public static bool UserSignedIn;
        public static CultureInfo AppCurrentCulture;

        public App()
        {
            InitializeComponent();
            
            AppResources.Culture = CultureInfo.CurrentCulture;

            DependencyService.Register<Repository>();
            MainPage = new HomePage();
        }

        protected override void OnStart()
        {
            Routing.RegisterRoute("billingdetailpage", typeof(BillingDetailPage));
            Routing.RegisterRoute("settings", typeof(SettingsPage));
            Routing.RegisterRoute("accountpage", typeof(AccountPage));
            Routing.RegisterRoute("authenticationpage", typeof(AuthenticationPage));
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
        //public static  bool PromptToConfirmExit
        //{
        //    get
        //    {
        //        bool promptToConfirmExit = false;
        //        if (App.Current.MainPage is ContentPage)
        //        {
        //            promptToConfirmExit = true;
        //        }
        //        else if (App.Current.MainPage is Xamarin.Forms.MasterDetailPage masterDetailPage
        //                 && masterDetailPage.Detail is NavigationPage detailNavigationPage)
        //        {
        //            promptToConfirmExit = detailNavigationPage.Navigation.NavigationStack.Count <= 1;
        //        }
        //        else if (App.Current.MainPage is NavigationPage mainPage)
        //        {
        //            if (mainPage.CurrentPage is TabbedPage tabbedPage
        //                && tabbedPage.CurrentPage is NavigationPage navigationPage)
        //            {
        //                promptToConfirmExit = navigationPage.Navigation.NavigationStack.Count <= 1;
        //            }
        //            else
        //            {
        //                promptToConfirmExit = mainPage.Navigation.NavigationStack.Count <= 1;
        //            }
        //        }
        //        else if (App.Current.MainPage is TabbedPage tabbedPage
        //                 && tabbedPage.CurrentPage is NavigationPage navigationPage)
        //        {
        //            promptToConfirmExit = navigationPage.Navigation.NavigationStack.Count <= 1;
        //        }
        //        return promptToConfirmExit;
        //    }
        //}

    }
}
