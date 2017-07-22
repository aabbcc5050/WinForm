using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N1;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            A oa = new A();
            oa.Myls();
        }
    }
}

namespace N1
{
    class A
    {
        public void Myls() {
            Console.WriteLine("test");
            Console.ReadLine();
        }
    }
}
