using MugerKing.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MugerKing.Converters
{
    public class TabTypesToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is TabTypes currentTab && parameter is TabTypes myTabType && currentTab == myTabType)
            {
                if (Application.Current.Resources.TryGetValue("Primary", out var primaryColor))
                    return (Color)primaryColor;
            }

            if(Application.Current.Resources.TryGetValue("Secondary", out var secondaryColor))
                return (Color)secondaryColor;

            return Color.FromRgb(80, 35, 20); //Secondary Color 
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
