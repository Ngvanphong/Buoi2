using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    public class Chair : IFurniture
    {
        public string Name { set; get; }
        public string Description { set; get; }
        public void DisplayInfo()
        {
            throw new NotImplementedException();
        }

        public void DisplayInfo(string name)
        {
            throw new NotImplementedException();
        }

        public void DisplayInfo(int price)
        {
            throw new NotImplementedException();
        }

        public double TotalPrice()
        {
            throw new NotImplementedException();
        }
    }
}
