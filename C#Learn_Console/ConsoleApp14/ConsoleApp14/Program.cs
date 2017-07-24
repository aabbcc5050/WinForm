using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            string Str1 = "nihaoa";
            string Str2 = "wobuhao";
            string Str3 = null;
            DateTime dt = new DateTime();
            string strB = String.Format("{0:d}",dt);
            Console.WriteLine("[{0}]equal[{1}]:[{2}]",Str1,Str2,String.Equals(Str1,Str2));
            Console.WriteLine("[{0}]equal[{1}]:[{2}]", Str1, Str3, Str1.Equals(Str3));
            Console.WriteLine("[{0}]equal[{1}]:[{2}]", Str3, Str1, Str1.Equals(Str3));//竟然没有空指针异常
            Console.WriteLine(Str3);
            Console.WriteLine(strB);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
