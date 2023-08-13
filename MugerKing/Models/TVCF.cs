using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MugerKing.Models
{
    public class TVCF
    {
        public TVCF(string name, string url, string imageUrl)
        {
            Name = name;
            Url = url;
            ImageUrl = imageUrl;
        }

        public string Name { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
    }
}
