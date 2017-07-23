using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2008;
            object obj = i;
            Console.WriteLine("1. i的值为{0},装箱之后的对象为{1}",i,obj);
            i = 927;
            Console.WriteLine("2. i的值为{0},装箱之后的对象为{1}", i, obj);
            int j = (int)obj;
            Console.WriteLine("装箱对象{0},值为{1}", obj, j);
            Console.ReadLine();
        }
    }
}
