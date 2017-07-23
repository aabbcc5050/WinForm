using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入年份:");
            string str = Console.ReadLine();
            int year = Int32.Parse(str);
            bool isleapyear = (year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0));
            string yesno = isleapyear ? "是" : "不是";
            Console.WriteLine("{0}年{1}闰年",year,yesno);
            Console.ReadLine();
        }
    }
}
