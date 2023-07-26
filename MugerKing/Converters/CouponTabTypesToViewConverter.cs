using MugerKing.Enums;
using MugerKing.Views.Coupon;
using System.Globalization;

namespace MugerKing.Converters
{
    public class CouponTabTypesToViewConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is CouponTabType couponTabType)
            {
                return couponTabType switch
                {
                    CouponTabType.Store => StoreView.Instance,
                    CouponTabType.KingOrder => KingOrderView.Instance,
                    CouponTabType.Delivery => DeliveryView.Instance,
                    _ => null
                };
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}