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
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.Text;
using CharterSampleApp.CustomRenderers;
using CharterSampleApp.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(EntryBoxRenderer), typeof(EntryBoxRendererAndroid))]
namespace CharterSampleApp.Droid.CustomRenderers
{
     class EntryBoxRendererAndroid : EntryRenderer
    {
        public EntryBoxRendererAndroid(Context context) : base(context)
        {
                
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                GradientDrawable gd = new GradientDrawable();

                //Below line is useful to give border color
                gd.SetColor(global::Android.Graphics.Color.Transparent);

                this.Control.SetBackground(gd);
                this.Control.SetRawInputType(InputTypes.TextFlagNoSuggestions);
                Control.SetHintTextColor(ColorStateList.ValueOf(global::Android.Graphics.Color.White));
            }
        }
    }
}