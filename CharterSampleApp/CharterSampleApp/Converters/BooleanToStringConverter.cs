using System;
using System.Globalization;
using System.Text.RegularExpressions;

using CharterSampleApp.Resources;

using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace CharterSampleApp.Converters
{
    /// <summary>
    /// This class have methods to convert the string values to boolean.     
    /// </summary>
    [Preserve(AllMembers = true)]
    public class BooleanToStringConverter : IValueConverter
    {
        /// <summary>
        /// This method is used to convert the boolean to a string for available label.
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="targetType">The target</param>
        /// <param name="parameter">The parameter</param>
        /// <param name="culture">The culture</param>
        /// <returns>The result</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
            {
                return AppResources.NowAvailable;
            }
            else
            {
                return AppResources.ComingSoon;
            }
        }

        /// <summary>
        /// This method is used to re-convert the string to a boolean for available label.
        /// </summary>
        /// <param name="value">The value</param>
        /// <param name="targetType">The target</param>
        /// <param name="parameter">The parameter</param>
        /// <param name="culture">The culture</param>
        /// <returns>The result</returns>
        /// 
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return true;
        }
    }
}