using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Program
    {
        class MyClass1
        {
            private int x = 0;
            private int y = 0;
            public int X { get; set; }
            public int Y { get; set; }
            public int Add1() {
                return X + Y;
            }
        }
        class MyClass2 : MyClass1
        {
            private int z = 0;
            public int Z { get; set; }
            public int Add2() { return X + Y + Z; }
        }
        static void Main(string[] args)
        {
            MyClass1 myclass1 = new MyClass1();
            MyClass2 myclass2 = new MyClass2();
            myclass1.X = 3;
            myclass1.Y = 5;
            myclass2.X = 3;
            myclass2.Y = 5;
            myclass2.Z = 7;
            Console.WriteLine(myclass1.Add1());
            Console.WriteLine(myclass2.Add1());
            Console.WriteLine(myclass2.Add2());
        }
    }
}
