using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi9
{
    public class Student
    {
        public Student()
        {
                
        }
        public Student(string name,int id,int age)
        {
            //Id = id;
            //Name = name;
            //Age = age;
            (Name, Age, Id) = (name, age, id);
        }
        public int Id { set; get; }
        public string Name { set; get; }
        public int Age { set; get; }
        
    }
}
