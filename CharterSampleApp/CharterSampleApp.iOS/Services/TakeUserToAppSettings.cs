using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CharterSampleApp.iOS.Services;
using CharterSampleApp.Interfaces;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(CharterSampleApp.iOS.Services.TakeUserToAppSettings))]
namespace CharterSampleApp.iOS.Services
{
    class TakeUserToAppSettings : ITakeUserToAppSettings
    {
        public void GoToAppSettings()
        {
            var url = new NSUrl($"app-settings:com.companyname.CharterSampleApp");
            UIApplication.SharedApplication.OpenUrl(url);

          //  UIApplication.SharedApplication.OpenUrl(new NSUrl("app-settings:"));

        }
    }
}