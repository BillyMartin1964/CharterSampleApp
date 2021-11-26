using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Content.Res;
using Android.OS;
using Xamarin.Forms;

namespace CharterSampleApp.Droid
{
    [Activity(Theme = "@style/Theme.SplashScreen", //Indicates the theme to use for this activity
        MainLauncher = true, ScreenOrientation = ScreenOrientation.Portrait,//Set it as boot activity
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
        NoHistory = true)]
    //Doesn't place it in back stack
    public class SplashScreenActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //SetContentView(Resource.Layout.splashLayout);

            if (Device.Idiom == TargetIdiom.Phone)
                RequestedOrientation = ScreenOrientation.Portrait;

            if (Device.Idiom == TargetIdiom.TV || Device.Idiom == TargetIdiom.Tablet)
                RequestedOrientation = ScreenOrientation.SensorLandscape;
            System.Threading.Thread.Sleep(2000);
            StartActivity(new Intent(this, typeof(MainActivity)));

            // Create your application here
            //System.Threading.Thread.Sleep(2000); //Let's wait awhile...
            //this.StartActivity(typeof(MainActivity));

            //var intent = new Intent(this, typeof(MainActivity));
            //if (Intent.Extras != null)
            //    intent.PutExtras(Intent.Extras); // copy push info from splash to main
            //StartActivity(intent);
        }

        public override void OnConfigurationChanged(Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);

            if (Device.Idiom == TargetIdiom.Phone)
                RequestedOrientation = ScreenOrientation.Portrait;

            if (Device.Idiom == TargetIdiom.TV || Device.Idiom == TargetIdiom.Tablet)
                RequestedOrientation = ScreenOrientation.SensorLandscape;
        }
    }
}