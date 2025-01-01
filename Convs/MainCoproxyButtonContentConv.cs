using Sheas_Cealer.Consts;
using System;
using System.Globalization;
using System.Windows.Data;

namespace Sheas_Cealer.Convs;

internal class MainCoproxyButtonContentConv : IMultiValueConverter
{
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        bool isCoproxyRunning = (bool)values[0];
        bool isConginxIniting = (bool)values[1];
        bool isComihomoIniting = (bool)values[2];

        return isConginxIniting || isComihomoIniting ? MainConst.CoproxyButtonIsInitingContent :
            isCoproxyRunning ? MainConst.CoproxyButtonIsRunningContent : MainConst.CoproxyButtonIsStoppedContent;
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) => throw new NotImplementedException();
}