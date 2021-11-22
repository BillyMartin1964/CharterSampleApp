using Foundation;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CharterSampleApp.iOS.Effects;
using CharterSampleApp.Effects;
using CoreGraphics;
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
            try
            {
                var effect = (ShadowEffect)Element.Effects.FirstOrDefault(e => e is ShadowEffect);

                if (effect != null)
                {
                    Container.Layer.CornerRadius = effect.Radius;
                    Container.Layer.ShadowColor = effect.Color.ToCGColor();
                    Container.Layer.ShadowOffset = new CGSize(effect.DistanceX, effect.DistanceY);
                    Container.Layer.ShadowOpacity = effect.Opacity;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot set property on attached control. Error: ", ex.Message);
            }
        }

        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
    }
}