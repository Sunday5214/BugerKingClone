using CommunityToolkit.Mvvm.ComponentModel;
using MugerKing.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MugerKing.ViewModels
{
    public partial class InfomationViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<TVCF> cfList;

        [ObservableProperty]
        private ObservableCollection<Event> eventList;

        public InfomationViewModel() 
        {
            CfList = new ObservableCollection<TVCF>()
            {
                new TVCF("헬 마우블로 와퍼", "", "homeimage1.png"),
                new TVCF("헬 마우블로 와퍼", "", "homeimage1.png"),
                new TVCF("헬 마우블로 와퍼", "", "homeimage1.png"),
                new TVCF("헬 마우블로 와퍼", "", "homeimage1.png"),
                new TVCF("헬 마우블로 와퍼", "", "homeimage1.png"),
                new TVCF("헬 마우블로 와퍼", "", "homeimage1.png"),
                new TVCF("헬 마우블로 와퍼", "", "homeimage1.png"),
                new TVCF("헬 마우블로 와퍼", "", "homeimage1.png"),
                new TVCF("헬 마우블로 와퍼", "", "homeimage1.png"),
                new TVCF("헬 마우블로 와퍼", "", "homeimage1.png")
            };

            EventList = new ObservableCollection<Event>()
            {
                new Event("", "homeimage1.png"),
                new Event("", "homeimage1.png"),
                new Event("", "homeimage1.png"),
                new Event("", "homeimage1.png"),
            };
        }    
    }
}
