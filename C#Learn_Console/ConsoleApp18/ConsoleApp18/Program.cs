using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        public struct Rect
        {
            public double width;
            public double height;
            public Rect(double x,double y)
            {
                width = x;
                height = y;
            }
            public double Area()
            {
                return width * height;
            }
        }

        static void Main(string[] args)
        {
            Rect rect1;
            rect1.width = 5;
            rect1.height = 3;
            Console.WriteLine("矩形的面积是:"+rect1.Area());
            Rect rect2 = new Rect(6,4);
            Console.WriteLine("矩形的面积是:"+rect2.Area());
        }
    }
}
