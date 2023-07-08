using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    public class Dog
    {
        public string Name;
        public Dog(string Name)
        {
            this.Name = Name;   
        }
        public Dog()
        {
            
        }

        public void DisplayName()
        {
            Console.WriteLine(this.Name);
        }
        public static void DisplayNameDog(string name)
        {
            Console.WriteLine(name);
        }
    }
}
