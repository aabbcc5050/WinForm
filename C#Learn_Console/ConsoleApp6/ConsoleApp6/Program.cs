using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //显示类型转换
            double x = 19810927.0112D;
            int y1 = (int)x;                   
            int y2 = Convert.ToInt32(x);    //通过关键字Convert进行显示转换,两种转换结果是一样的
            Console.WriteLine(y1);
            Console.WriteLine(y2);
            Console.ReadLine();
        }
    }
}
