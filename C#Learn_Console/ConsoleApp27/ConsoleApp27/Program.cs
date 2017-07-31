using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                object obj = null;
                int N = (int)obj;
            }
            catch(Exception ex)
            {
                Console.WriteLine("捕获异常:"+ ex);
            }
            Console.ReadLine();
        }
    }
}
