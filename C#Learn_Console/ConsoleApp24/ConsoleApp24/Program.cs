using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass();
            ImyInterface1 i1 = myclass;
            ImyInterface2 i2 = myclass;
            Console.WriteLine(i1.Add());
            Console.WriteLine(i2.Add());
            Console.ReadLine();
        }

        interface ImyInterface1
        {
            int Add();
        }

        interface ImyInterface2
        {
            int Add();
        }

        class MyClass : ImyInterface1, ImyInterface2
        {
            int ImyInterface1.Add()
            {
                int x = 3;
                int y = 5;
                return x + y;
            }

            int ImyInterface2.Add()
            {
                int x = 3;
                int y = 5;
                int z = 7;
                return x + y + z;
            }
        }
    }
}
