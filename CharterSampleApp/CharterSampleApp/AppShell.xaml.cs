using CharterSampleApp.ViewModels;
using CharterSampleApp.Views;

using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CharterSampleApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(BillingDetailPage), typeof(BillingDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        //protected override bool OnBackButtonPressed()
        //{
        //    // true or false to disable or enable the action
        //    return base.OnBackButtonPressed();
        //}

        //private Page _lastPage;

        //protected override void OnNavigating(ShellNavigatingEventArgs args)
        //{
        //    _lastPage = CurrentPage;
        //    base.OnNavigating(args);
        //}
    }
}
