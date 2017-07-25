using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = 1000;
            StringBuilder sb = new StringBuilder("用一生下载你",100);
            sb.Append("VS啦啦啦啦");
            Console.WriteLine(sb);
            sb.AppendFormat("{0:C}",Num);
            Console.WriteLine(sb);
            sb.Insert(0,"名称:");
            Console.WriteLine(sb);
            sb.Remove(15, sb.Length - 15);
            Console.WriteLine(sb);
            sb.Replace("名称:","一生所爱");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
