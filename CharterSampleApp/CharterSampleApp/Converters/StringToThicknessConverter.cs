using System;
using System.Globalization;
using Xamarin.Forms;

namespace CharterSampleApp.Converters
{
  public  class StringToThicknessConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Thickness margin = new Thickness(0, 0, 0, (int)value);

            return margin;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
