using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "用一生下载你";
            object obj = str;
            try
            {
                int i = (int)obj;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally {
                Console.WriteLine("程序执行完毕");
            }
            Console.ReadLine();
        }
    }
}
