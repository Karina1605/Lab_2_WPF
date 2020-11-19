using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace Lab_2.Converters
{
    public class ColorsConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value == null || parameter == null)
                return false;
            int dValue;
            int dParameter;
            if (!Int32.TryParse(value.ToString(), out dValue) || !Int32.TryParse(parameter.ToString(), out dParameter))
                return false;
            return (dValue < dParameter);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
