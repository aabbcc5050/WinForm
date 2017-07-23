using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            object obj = i;
            bool b1 = i is int;
            bool b2= obj is int;
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.ReadLine();
        }
    }
}
