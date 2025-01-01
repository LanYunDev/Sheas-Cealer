using System;
using System.Globalization;
using System.Windows.Data;

namespace Sheas_Cealer.Convs;

internal class MainCoproxyButtonIsEnabledConv : IMultiValueConverter
{
    public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
    {
        bool isConginxIniting = (bool)values[0];
        bool isComihomoIniting = (bool)values[1];
        bool isNginxExist = (bool)values[2];
        bool isNginxIniting = (bool)values[3];
        bool isNginxRunning = (bool)values[4];
        bool isMihomoExist = (bool)values[5];
        bool isMihomoIniting = (bool)values[6];
        bool isMihomoRunning = (bool)values[7];

        return !isConginxIniting && !isComihomoIniting && !isNginxIniting && !isMihomoIniting && !isNginxRunning && !isMihomoRunning;
    }

    public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) => throw new NotImplementedException();
}