using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MugerKing.Models
{
    public class Event
    {
        public Event(string url, string imageUrl)
        {
            Url = url;
            ImageUrl = imageUrl;    
        }

        public string Url { get; set; }
        public string ImageUrl { get; set; }
    }
}
