using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    public class Apple : Fruit
    {
        public string Shape { set; get; }
        public Apple(string name, string color, double weight, string shape) 
            : base(name, color, weight)
        {
            Shape = shape;
        }
    }
}
