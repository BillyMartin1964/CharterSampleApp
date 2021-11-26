using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

using CharterSampleApp.Interfaces;
using CharterSampleApp.Models;
using CharterSampleApp.Resources;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CharterSampleApp.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {
        string tempFlag, languageAbrev;
        public SettingsViewModel()
        {
            AssignLanguageFlag();
            Languages = CreateLanguages();
        }

        private ICommand openDeviceSettings;
        public ICommand OpenDeviceSettings =>
            openDeviceSettings ??
            (openDeviceSettings = new Command(ExecuteOpenDeviceSettings));

        private void ExecuteOpenDeviceSettings(object obj)
        {
            DependencyService.Get<ITakeUserToAppSettings>().GoToAppSettings();
        }


        private ObservableCollection<Language> languages;
        public ObservableCollection<Language> Languages
        {
            get { return languages; }

            set { SetProperty(ref languages, value); }
        }

    

       
        public ObservableCollection<Language> CreateLanguages()
        {
            return new ObservableCollection<Language>
            {
              new Language()
                {
                    _id = 0, LanguageAbreviation = "en", LanguageName = "English",
                    FlagImage = ImageSource.FromResource("CharterSampleApp.UserInterface.Images.LanguageFlags.america.png")
                },
                new Language()
                {
                    _id = 1, LanguageAbreviation = "fr", LanguageName = "Français",
                    FlagImage = ImageSource.FromResource("CharterSampleApp.UserInterface.Images.LanguageFlags.france.png")
                },
               new Language()
                {
                    _id = 2, LanguageAbreviation = "es", LanguageName = "Español",
                    FlagImage = ImageSource.FromResource("CharterSampleApp.UserInterface.Images.LanguageFlags.spain.png")
                }
            };
        }


        ICommand languageSelectedCommand;
        public ICommand LanguageSelectedCommand =>
            languageSelectedCommand ??
            (languageSelectedCommand = new Command<Language>(async (x) => await ExecuteLanguageSelectedCommand(x)));

        public async Task ExecuteLanguageSelectedCommand(Language e)
        {
            if (e.LanguageAbreviation == null)
                return;

            var currentLanguage = AppResources.Culture;

            string englishName = string.Empty;

            var languageAbrev = e?.LanguageAbreviation;

            CultureInfo[] neutralCultureInfoList = CultureInfo.GetCultures(CultureTypes.NeutralCultures);

            Thread.CurrentThread.CurrentUICulture = neutralCultureInfoList.ToList().First(element => languageAbrev != null && element.TwoLetterISOLanguageName.Contains(languageAbrev));

            AppResources.Culture = Thread.CurrentThread.CurrentUICulture;
            var ci = Thread.CurrentThread.CurrentUICulture;

            //string TitleString = AppResources.PopupTitle;
            //string MessageString = $"{AppResources.PopupLanguageMessage} {AppResources.to} {AppResources.Culture.NativeName}";

            //string OkString = AppResources.Okay;
            //string CancelString = AppResources.Cancel;

            //var action = await Application.Current.MainPage.DisplayAlert(TitleString, MessageString, OkString, CancelString);
            //SelectedItem = null;
            //LanguagelistVisible = false;

            //MainSettingsGridVisible = true;
            //if (action)
            //{

                //if (Device.RuntimePlatform == Device.UWP)
                //{
                //    Analytics.TrackEvent("Changed Language to " + englishName + " (UWP)");
                //}
                //else
                //{
                //    Analytics.TrackEvent("Changed Language to " + englishName + " (Non UWP)");
                //}

                SetCultureInfo(CultureInfo.CurrentCulture);

                //MessagingCenter.Send<SettingsViewModel>(this, "ResetMenu");

                //await _navigationService.NavigateAsync("/PrismMasterDetailPage/NavigationPage/TabbedHomePage");
            //}
            //else
            //{
            //    Thread.CurrentThread.CurrentUICulture = currentLanguage;
            //}
        }

        public void SetCultureInfo(CultureInfo cultureInfo)
        {
            OnPropertyChanged();
        }
    }
}