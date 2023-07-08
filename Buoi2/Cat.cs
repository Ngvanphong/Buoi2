using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Buoi2
{
    public class Cat
    {
        public string Color;
        public double Height;
        public double Weight;

        public Cat(string color, double height, double weight)
        {
            Color = color;
            Height = height;
            Weight = weight;
        }
        public Cat()
        {

        }

        public void DisplayInfo()
        {
            Console.WriteLine("Color: " +
                Color + " Height: "
                + Height.ToString() +
                " Weight: " + Weight.ToString());
            //string resultString = $"Color: {Color}, Height: {Height},Weight: {Weight}";
            //string testString = @"test string \n test";
            //Console.WriteLine($"Color: {Color}, Height: {Height},Weight: {Weight}");
            //Console.WriteLine("Color: {0}, Height:{1},Weight: {2}",Color,Height,Weight);
            //Console.WriteLine(resultString);
        }

    }
}
