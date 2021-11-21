namespace CharterSampleApp.Behaviors
{
    public class SelectionChangedBehavior //: Behavior<SfComboBox>
    {
        //const string ResourceId = "Yatzy.Resources.AppResources";

        //ResourceManager resmgr = new ResourceManager(ResourceId, typeof(TranslateExtension).GetTypeInfo().Assembly);
        //public Command Display { get; private set; }

        //SettingsViewModel employeeViewModel;




        //protected override void OnAttachedTo(SfComboBox bindable)
        //{
        //    bindable.SelectionChanged += Bindable_SelectionChanged;
        //    base.OnAttachedTo(bindable);
        //}

        //protected override void OnDetachingFrom(SfComboBox bindable)
        //{
        //    bindable.SelectionChanged -= Bindable_SelectionChanged;
        //    base.OnDetachingFrom(bindable);
        //}

        //async void Bindable_SelectionChanged(object sender, Syncfusion.XForms.ComboBox.SelectionChangedEventArgs e)
        //{
        //   // settingsViewModel = new SettingsViewModel();
        //    var selectedValue = e.Value as Language;


        //    var currentLanguage = AppResources.Culture;

        //    string englishName = string.Empty;


        //    switch (selectedValue?.Index)
        //    {
        //        case 0:
        //            englishName = "Dutch";
        //            break;
        //        case 1:
        //            englishName = "English";
        //            break;
        //        case 2:
        //            englishName = "French";
        //            break;
        //        case 3:
        //            englishName = "German";
        //            break;
        //        case 4:
        //            englishName = "Italian";
        //            break;
        //        case 5:
        //            englishName = "Japanese";
        //            break;
        //        case 6:
        //            englishName = "Korean";
        //            break;
        //        case 7:
        //            englishName = "Portuguese";
        //            break;
        //        case 8:
        //            englishName = "Romanian";
        //            break;
        //        case 9:
        //            englishName = "Russian";
        //            break;
        //        case 10:
        //            englishName = "Spanish";
        //            break;
        //        case 11:
        //            englishName = "Swedish";
        //            break;
        //        default:
        //            return;
        //    }

        //    CrossMultilingual.Current.CurrentCultureInfo = CrossMultilingual.Current.NeutralCultureInfoList.ToList()
        //        .First(element => element.EnglishName.Contains(englishName));

        //    AppResources.Culture = CrossMultilingual.Current.CurrentCultureInfo;
        //    var ci = CrossMultilingual.Current.CurrentCultureInfo;

        //    string TitleString = resmgr.GetString("PopupTitle", ci);
        //    string MessageString = resmgr.GetString("PopupMessage", ci) + " " + resmgr.GetString("Game", ci) + " " +
        //                           resmgr.GetString("to", ci) + " " + resmgr.GetString(englishName, ci);
        //    string OkString = resmgr.GetString("Okay", ci);
        //    string CancelString = resmgr.GetString("Cancel", ci);

        //    var action =
        //        await Application.Current.MainPage.DisplayAlert(TitleString, MessageString, OkString, CancelString);

        //    if (action)
        //    {


        //        if (Device.RuntimePlatform == Device.UWP)
        //        {
        //            Analytics.TrackEvent("Landscape Changed Language to " + englishName + " (UWP)");

        //            // await Navigation.PushModalAsync(new LandscapeSettingsPage());
        //            await App.Current.MainPage.Navigation.PopModalAsync();
        //            //await Application.Current..PopModalAsync();
        //        }
        //        else
        //        {
        //            Analytics.TrackEvent("Landscape Changed Language to " + englishName + " (Non UWP)");

        //            await App.Current.MainPage.Navigation.PopAsync();
        //        }

        //    }
        //    else
        //    {
        //        CrossMultilingual.Current.CurrentCultureInfo =
        //            currentLanguage; // CrossMultilingual.Current.NeutralCultureInfoList.ToList().First(element => element.EnglishName.Contains(currentLanguage));
        //        AppResources.Culture = CrossMultilingual.Current.CurrentCultureInfo;
        //        ci = CrossMultilingual.Current.CurrentCultureInfo;
        //    }




        //}
    }
}
