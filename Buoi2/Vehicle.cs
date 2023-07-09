using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    public class Vehicle : AbstractClass
    {
        public override void DisplayInfo(string name)
        {
           Console.WriteLine(name);
        }
    }
}
