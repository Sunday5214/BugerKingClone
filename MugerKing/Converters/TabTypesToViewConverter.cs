using MugerKing.Enums;
using MugerKing.Views;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MugerKing.Converters
{
    public class TabTypesToViewConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is TabTypes tabType)
            {
                switch(tabType) 
                {
                    case TabTypes.Home:
                        return HomeView.Instance;
                    case TabTypes.Coupon:
                        return CouponView.Instance;
                    case TabTypes.My:
                        return MyKingView.Instance;
                    case TabTypes.More: 
                        return MoreView.Instance;
                    default:
                        return null;
                }
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
