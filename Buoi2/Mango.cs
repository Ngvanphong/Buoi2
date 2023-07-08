using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    public class Mango : Fruit
    {
        public string Flavor { set; get; }
        public Mango(string name, string color, double weight, string flavor)
            : base(name, color, weight)
        {
            Flavor = flavor;

        }
        public void DisplayName()
        {
            Console.WriteLine(base.Name);
        }

    }
}
