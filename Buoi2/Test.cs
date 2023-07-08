using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    public class Test
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name= value; }
        }


        private int _age;
        public int Age 
        {
            get { return _age; }
            set { _age= value; }
        }


        private int _height;
        public int Height
        { 
            get { return _height; }
            set { _height= value; }
        }


        private int _weight;
        public int Weight 
        {
            get { return _weight; }
            set { _weight= value; }
        }


        public int Total { get;  private set; }
        public Test(string name)
        {
            this._name = name;
        }
        public Test()
        {
            
        }
        public Test(string name,int age)
        {
            this._age= age;
            _name = name;
        }
        public Test(string name,int age,int height, int weight)
        {
            (_name,_age,_weight,_height) = (name, age, weight, height);
        }
    

        public int TestFunction()
        {
            return _age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine(_name);
        }

        public static void DisplayInfo2(string testName="Default")
        {
            Console.WriteLine(testName);
        }

        public void SetTotal()
        {
            Total = _age + _weight + _height;
        }


    }
}
