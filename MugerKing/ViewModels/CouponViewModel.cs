using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MugerKing.Enums;

namespace MugerKing.ViewModels
{
    public partial class CouponViewModel : ObservableObject
    {
        [ObservableProperty]
        private CouponTabType currentTab = CouponTabType.Store;

        [RelayCommand]
        private void SelectedTabChanged(CouponTabType couponTabType)
        {
            CurrentTab = couponTabType;
        }
    }
}