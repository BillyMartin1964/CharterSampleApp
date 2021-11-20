using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CharterSampleApp.ContentViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignInForm : ContentView
    {
        public SignInForm()
        {
            InitializeComponent();
        }
    }
}