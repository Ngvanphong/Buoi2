using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    public class Oto : AbstractClass
    {
 
        public override void DisplayInfo(string name)
        {
            Console.WriteLine(StaticClass.FolderPath);
            Console.WriteLine(ConstantsClass.Folder);
        }
    }
    public partial class Building
    {
        public string Address { set; get; }
        public string City { set; get; }
        public void DisplayInfoAddress()
        {
            Console.WriteLine(Address);
        }
    }
}
