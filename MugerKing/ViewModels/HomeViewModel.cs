using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MugerKing.Models;
using MugerKing.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MugerKing.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Event> eventList;

        [ObservableProperty]
        private ObservableCollection<Buger> bugerList;

        [ObservableProperty]
        private int currentIdx;

        [RelayCommand]
        private void CurrentImagItemChanged(object currentItem)
        {
            if (currentItem is Event eventObject)
            {
                CurrentIdx = EventList.IndexOf(eventObject) + 1;
            }
        }

        [RelayCommand]
        private async Task OpenInfomationPage()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new InfomationPage());
        }

        public HomeViewModel()
        {
            EventList = new ObservableCollection<Event>()
            {
                new Event("", "homeimage1.png"),
                new Event("", "homeimage1.png"),
                new Event("", "homeimage1.png"),
                new Event("", "homeimage1.png"),
            };

            BugerList = new ObservableCollection<Buger>()
            {
                new Buger(0, "마우이 와퍼", "bugerkinglogo.svg", 2),
                new Buger(1, "마우이 와퍼", "bugerkinglogo.svg", 2),
                new Buger(2, "마우이 와퍼", "bugerkinglogo.svg", 2),
                new Buger(3, "마우이 와퍼", "bugerkinglogo.svg", 2),
                new Buger(4, "마우이 와퍼", "bugerkinglogo.svg", 2),
                new Buger(5, "마우이 와퍼", "bugerkinglogo.svg", 2),
                new Buger(6, "마우이 와퍼", "bugerkinglogo.svg", 2),
                new Buger(7, "마우이 와퍼", "bugerkinglogo.svg", 2),
            };
        }
    }
}
