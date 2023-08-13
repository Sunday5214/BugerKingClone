using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MugerKing.Models
{
    public class Buger
    {
        public Buger(int id, string name, string imageUrl, int spicyPoint)
        {
            Id = id;
            Name = name;
            ImageUrl = imageUrl;
            SpicyPoint = spicyPoint;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int SpicyPoint { get; set; }
    }
}
