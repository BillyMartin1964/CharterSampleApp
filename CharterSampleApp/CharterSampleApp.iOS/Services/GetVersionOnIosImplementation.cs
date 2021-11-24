
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CharterSampleApp.Interfaces;
using CharterSampleApp.iOS.Services;
using CoreFoundation;
using Foundation;
using Xamarin.Forms;

[assembly: Dependency(typeof(GetVersionOnIosImplementation))]
namespace CharterSampleApp.iOS.Services
{
    public class GetVersionOnIosImplementation : IGetAppVersion
    {
        public string GetAppVersion()
        {
           
                return NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleShortVersionString").ToString();
           
        }
            public int GetBuild()
            {
                return int.Parse(NSBundle.MainBundle.ObjectForInfoDictionary("CFBundleVersion").ToString());
            }
    }
}