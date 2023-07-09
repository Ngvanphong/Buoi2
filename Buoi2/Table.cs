using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    public class Table : Fruit, IFurniture, IInfomation
    {
        public double Kg { set; get; }
        public double Price { set; get; }
        public Table(string name, string color, double weight,
            double kg, double price) : base(name, color, weight)
        {
            Kg = kg;
            Price = price;
        }
        public Table(string name, string color, double weight)
            : base(name, color, weight)
        {

        }
        public Table() : base()
        {

        }
       

    
        public void DisplayInfo()
        {
            Console.WriteLine(Kg.ToString());
        }

        public void DisplayInfo(string name)
        {
            Console.WriteLine(name);
        }

        public void DisplayInfo(int price)
        {
            Console.WriteLine(price.ToString());
        }

        public void DisplayInformation()
        {
            throw new NotImplementedException();
        }

        public double TotalPrice()
        {
            double result = Math.Sqrt(Kg);

            result =Math.Pow(Kg, 5);
            result = Math.Sin(Math.PI / 2);
            result =Math.Abs(Kg);

            return result;

        }
    }
}
