using System;
using Xamarin.Forms;

namespace CharterSampleApp.Effects
{
    public class ShadowEffect : RoutingEffect
    {
        public ShadowEffect() : base("BillyMartin.LabelShadowEffect")
        {
        }

        public float Radius { get; set; } = 5;

        public Color Color { get; set; } = Color.Black;


        public float Opacity { get; set; } = 1.0f;

        public float DistanceX { get; set; } = 3;

        public float DistanceY { get; set; } = 3;


        [Xamarin.Forms.TypeConverter(typeof(Xamarin.Forms.FontSizeConverter))]
        public Double FontSize{ get; set; }
      



        //[Xamarin.Forms.TypeConverter(typeof(Xamarin.Forms.FontSizeConverter))]
        //public static readonly BindableProperty FontSize
        //    = BindableProperty.Create(propertyName: nameof(FontSize)
        //        , returnType: typeof(Xamarin.Forms.View)
        //        , declaringType: typeof(Double)
        //        , defaultBindingMode: BindingMode.OneWay
        //    );


        public FontAttributes FontAttributes { get; set; } //= FontAttributes.None;

        public string FontFamily { get; set; }

        public Xamarin.Forms.LayoutOptions HorizontalOptions { get; set; } //= LayoutOptions.Fill;
        public Xamarin.Forms.LayoutOptions VerticalOptions { get; set; } //= LayoutOptions.Fill;

        public Xamarin.Forms.TextAlignment HorizontalTextAlignment { get; set; }// = TextAlignment.Start;

        public Xamarin.Forms.TextAlignment VerticalTextAlignment { get; set; }// = TextAlignment.Start;


    }
}
