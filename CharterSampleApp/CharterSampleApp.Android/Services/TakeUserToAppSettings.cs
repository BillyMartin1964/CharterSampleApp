using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CharterSampleApp.Droid.Services;
using CharterSampleApp.Interfaces;
using Xamarin.Forms;
using Android.Content.PM;
using Application = Android.App.Application;

[assembly: Dependency(typeof(CharterSampleApp.Droid.Services.TakeUserToAppSettings))]
namespace CharterSampleApp.Droid.Services
{
    class TakeUserToAppSettings : ITakeUserToAppSettings
    {
        public void GoToAppSettings()
        {
            var intent = new Intent(Android.Provider.Settings.ActionApplicationDetailsSettings);
            intent.AddFlags(ActivityFlags.NewTask);
            string package_name = "com.companyname.chartersampleapp";
            var uri = Android.Net.Uri.FromParts("package", package_name, null);
            intent.SetData(uri);
            Application.Context.StartActivity(intent);
            
        }
    }
}