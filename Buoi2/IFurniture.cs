using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    public interface IFurniture
    {
        void DisplayInfo();

        void DisplayInfo(string name);

        void DisplayInfo(int price);


        double TotalPrice();



    }
}
