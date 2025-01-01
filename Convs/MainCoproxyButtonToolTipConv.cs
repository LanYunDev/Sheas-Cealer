using Sheas_Cealer.Consts;
using System;
using System.Globalization;
using System.Windows.Data;

namespace Sheas_Cealer.Convs;

internal class MainCoproxyButtonToolTipConv : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        bool isCoproxyRunning = (bool)value;

        return isCoproxyRunning ? MainConst.CoproxyButtonIsRunningToolTip : MainConst.CoproxyButtonIsStoppedToolTip;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) => throw new NotImplementedException();
}