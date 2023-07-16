using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    public abstract class AbstractClass
    {
        public string Name { get; set; }
        public abstract void DisplayInfo(string name);
        public void Display2(string name)
        {
            Console.WriteLine(name);
        }
    }

    public partial class Building
    {
        public string Name { get; set; }
        public double CountStory { set; get; }
        public void DisplayInfoName()
        {
            Console.WriteLine(Name + " " + CountStory);
        }
    }
}
