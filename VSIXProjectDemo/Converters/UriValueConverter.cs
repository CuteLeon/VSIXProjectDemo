﻿using System;
using System.Globalization;
using System.Windows.Data;

namespace VSIXProjectDemo.Converters
{
    public class UriValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new Uri(value as string);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value is Uri uri) ? uri.AbsoluteUri : string.Empty;
        }
    }
}
