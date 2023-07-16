using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    public  class Fruit
    {
        protected string Name { set; get; }
        public string Color { set; get; }
        public double Weight { set; get; }
        public double PricePerKg { set; get; }
        public Fruit(string name,string color,double weight)
        {
            Name = name;
            Color = color;
            Weight = weight;
        }
        public Fruit()
        {
            
        }

        public double TotalPrice()
        {
           return  PricePerKg * Weight;
        }


    }
}
