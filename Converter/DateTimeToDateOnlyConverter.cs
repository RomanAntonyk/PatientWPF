using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Lab_2.Converter
{
    public class DateTimeToDateOnlyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            DateOnly dateOnly = (DateOnly)value;
            return new DateTime(dateOnly.Year, dateOnly.Month, dateOnly.Day);
           
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
             DateTime dateTime = (DateTime)value;
            return new DateOnly(dateTime.Year, dateTime.Month, dateTime.Day);
        }
    }
}
