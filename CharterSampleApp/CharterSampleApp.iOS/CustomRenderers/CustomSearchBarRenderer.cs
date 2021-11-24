using Foundation;

using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using UIKit;
using System.Diagnostics;

[assembly: ExportRenderer(typeof(SearchBar), typeof(CharterSampleApp.iOS.CustomRenderers.CustomSearchBarRenderer))]
namespace CharterSampleApp.iOS.CustomRenderers
{


    public class CustomSearchBarRenderer : SearchBarRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<SearchBar> e)
        {
            base.OnElementChanged(e);
            //if (Control != null)
            //{
            //    Control.Subviews[0].Subviews[0].RemoveFromSuperview();
            //}
        }
    }
}
