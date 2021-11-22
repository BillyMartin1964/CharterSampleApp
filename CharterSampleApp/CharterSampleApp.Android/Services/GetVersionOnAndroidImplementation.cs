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
using Android.Content.PM;
using AndroidX.Core.Content.PM;
using CharterSampleApp.Droid.Services;
using CharterSampleApp.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(GetVersionOnAndroidImplementation))]
namespace CharterSampleApp.Droid.Services
{
    public class GetVersionOnAndroidImplementation: IGetAppVersion
    {
        public string GetAppVersion()
        {
            var context = global::Android.App.Application.Context;

            PackageManager manager = context.PackageManager;
            PackageInfo info = manager.GetPackageInfo(context.PackageName, 0);

            return info.LongVersionCode.ToString();

            //var version = Application.Context.ApplicationContext.PackageManager
            //    .GetPackageInfo(Application.Context.ApplicationContext.PackageName, 0).GetLongVersionCode().ToString();

            //var version = Application.Context.ApplicationContext.GetPackageManager().GetPackageInfo(Context.ApplicationContext.PackageName(), 0);
            //long longVersionCode = PackageInfoCompat.GetLongVersionCode(version);
            //int versionCode = (int)longVersionCode;

            //return version;
        }
    }
}