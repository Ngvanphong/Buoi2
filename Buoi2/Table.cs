using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    public class Table : Fruit,IFurniture,IInfomation
    {
        public Table(string name, string color, double weight) : base(name, color, weight)
        {
        }

        public double Kg { set; get; }
        public double Price { set; get; }
        public void DisplayInfo()
        {
            Console.WriteLine(Kg.ToString());
        }

        public void DisplayInformation()
        {
            throw new NotImplementedException();
        }

        public double TotalPrice()
        {
            return Kg * Price;
        }
    }
}
