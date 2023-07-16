using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Buoi2
{
    public static class StaticClass
    {
        public static string FolderPath = @"C:\Microsoft";
        public static void DisplayInfo()
        {
            System.Console.WriteLine(FolderPath);
        }

    }
}
