using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Furniture
    {
        public string  Color { get; set; }
        public string Material { get; set; }
        public Furniture()
        {
            this.Color = "White";
            this.Material = "Wood";
        }
        public Furniture(string color,string material)
        {
            this.Color = color;
            this.Material = material;
        }
    }
}
