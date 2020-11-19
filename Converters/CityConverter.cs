using Lab_2.models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Data;

namespace Lab_2.Converters
{
    public class CityConverter : IValueConverter
    {
        private static string[] Rus = new string[] { "Воронеж", "Москва", "Санкт-Петербург", "Саратов", "Норильск", "Казань" };
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            City res = (City)Enum.Parse(typeof(City), value.ToString());
            if (value == null && parameter == null)
                return "Error";
            return Rus[(int)res];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
