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
using CharterSampleApp.Services;
using System.Threading.Tasks;
using System.IO;
using CharterSampleApp.Droid.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(ProfilePicPickerService))]
namespace CharterSampleApp.Droid.Services
{
    public class ProfilePicPickerService : IProfilePicPickerService
    {
        public Task<Stream> GetImageStreamAsync()
        {
            //Intent For Images
            Intent intent = new Intent();
            intent.SetType("image/*");
            intent.SetAction(Intent.ActionGetContent);

            //Start Activity
            MainActivity.Instance.StartActivityForResult(
                Intent.CreateChooser(intent, "Select Picture"),
                MainActivity.PickImageId);

            //Save TaskCompletion Source
            MainActivity.Instance.PickImageTaskCompletionSource = new TaskCompletionSource<Stream>();

            return MainActivity.Instance.PickImageTaskCompletionSource.Task;
        }
    }

}