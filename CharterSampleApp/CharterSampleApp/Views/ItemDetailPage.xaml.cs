using CharterSampleApp.ViewModels;

using System.ComponentModel;

using Xamarin.Forms;

namespace CharterSampleApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}