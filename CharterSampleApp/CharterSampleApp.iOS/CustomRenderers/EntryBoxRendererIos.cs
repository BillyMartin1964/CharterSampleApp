using Foundation;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CharterSampleApp.CustomRenderers;
using CharterSampleApp.iOS.CustomRenderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(EntryBoxRenderer), typeof(EntryBoxRendererIos))]
namespace CharterSampleApp.iOS.CustomRenderers
{
     class EntryBoxRendererIos : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                //Control.BorderStyle = UITextBorderStyle.None;
                //Below line is useful to give border color 
                Control.TintColor = UIColor.Red;
                //Control.Layer.CornerRadius = 10;
                Control.TextColor = UIColor.White;
            }
        }
    }
}