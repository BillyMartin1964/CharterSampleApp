using System;
using System.Globalization;
using Xamarin.Forms;

namespace CharterSampleApp.Converters
{
    public class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
           // return "data:image;base64," + Convert.ToBase64String(value);

          return value != null ? ImageSource.FromFile(value.ToString()) : null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
