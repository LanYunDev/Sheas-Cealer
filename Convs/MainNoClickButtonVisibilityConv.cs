using Sheas_Cealer.Consts;
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Sheas_Cealer.Convs;

internal class MainNoClickButtonVisibilityConv : IMultiValueConverter
{
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        bool isAdmin = (bool)values[0];
        bool isMidnight = (bool)values[1];

        return isAdmin && isMidnight ? Visibility.Visible : Visibility.Collapsed;
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) => throw new NotImplementedException();
}