using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Input;

using CharterSampleApp.ContentViews;
using CharterSampleApp.Extensions;
using CharterSampleApp.Models;
using CharterSampleApp.Services;

using Xamarin.Essentials;
using Xamarin.Forms;

namespace CharterSampleApp.ViewModels
{
    public class AccountViewModel : BaseViewModel
    {

        public AccountViewModel()
        {
          // ProfilePic = "unknownperson.png";
           ProfilePic =  ImageSource.FromResource("CharterSampleApp.UserInterface.Images.PNGs.unknownperson.png");
        }

        private ICommand getProfilePicCommand;
        public ICommand GetProfilePicCommand =>
            getProfilePicCommand ??
            (getProfilePicCommand = new Command(async () => await ExecuteGetProfilePicCommand()));

        async Task ExecuteGetProfilePicCommand()
        {
            Stream stream = await DependencyService.Get<IProfilePicPickerService>().GetImageStreamAsync();

            if (stream != null)
            {
                ProfilePic = ImageSource.FromStream(() => stream);
            }

        }

        private ImageSource profilePic;
        public ImageSource ProfilePic
        {
            get { return profilePic; }
            set
            {
                profilePic = value;
                OnPropertyChanged();
            }
        }
    }
}