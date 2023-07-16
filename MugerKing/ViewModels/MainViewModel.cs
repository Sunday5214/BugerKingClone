using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MugerKing.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MugerKing.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private TabTypes currentTab;

        public MainViewModel() 
        {
            CurrentTab = TabTypes.Home;
        }

        [RelayCommand]
        private void SelectedTabChanged(object selectedTab)
        {
            CurrentTab = (TabTypes)selectedTab;
        }
    }
}
