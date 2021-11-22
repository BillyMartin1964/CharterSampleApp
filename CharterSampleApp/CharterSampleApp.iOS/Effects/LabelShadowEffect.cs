using Foundation;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CharterSampleApp.iOS.Effects;
using CharterSampleApp.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using UIKit;

[assembly: ResolutionGroupName("BillyMartin")]
[assembly: ExportEffect(typeof(LabelShadowEffect),"LabelShadowEffect")]
namespace CharterSampleApp.iOS.Effects
{
    public class LabelShadowEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            throw new NotImplementedException();
        }

        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
    }
}