using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using Xamarin.Forms;

namespace CharterSampleApp.Converters
{
    public class ImageConverter : IValueConverter
    {
        //public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        //{
        //    if (value is string fileName && parameter is string assemblyName)
        //    {
        //        try
        //        {
        //            Debug.WriteLine("Assembly Name: " + assemblyName);  // Just for reference, remove in Release mode
        //            var imageSource = ImageSource.FromResource(assemblyName + "." + fileName, typeof(ImageConverter).GetTypeInfo().Assembly);
        //            return imageSource;
        //        }
        //        catch (Exception)
        //        {
        //            return value;
        //        }
        //    }
        //    else
        //        return value;
        //}

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }


        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // return "data:image;base64," + Convert.ToBase64String(value);

            return value != null ? ImageSource.FromFile(value.ToString()) : null;
        }

        //public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        //{
        //    return null;
        //}
    }
}
