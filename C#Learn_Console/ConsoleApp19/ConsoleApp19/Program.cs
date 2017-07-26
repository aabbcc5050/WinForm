using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        public Program() {
            Console.WriteLine("构造函数,new时候调用");
        }

        ~Program() {
            Console.WriteLine("析构函数,销毁的时候调用");
        }

        static void Main(string[] args)
        {
            Program program = new Program();
        }
    }
}
