using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        class MyClass1 {
            private int x = 0;
            private int y = 0;
            public int X { get; set; }
            public int Y { get; set; }
            public virtual int Add() {
                return X + Y;
            }
        }
        class MyClass2:MyClass1 //继承MyClass1
        {
            public override int Add() {
                int x = 5;
                int y = 7;
                return x + y;
            }
        }
        static void Main(string[] args)
        {
            MyClass2 myclass2 = new MyClass2();
            MyClass1 myclass1 = (MyClass1)myclass2;
            myclass1.X = 3;
            myclass1.Y = 5;
            Console.WriteLine(myclass2.Add());
            Console.WriteLine(myclass1.Add());
            Console.ReadLine();
        }
    }
}
