using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    public class OutRefSample
    {
        public double FirstNumber { set; get; }
        public double SecondNumber { set; get; }

        public void Add(out double result)
        {
            result = FirstNumber + SecondNumber;
        }

    }
}
