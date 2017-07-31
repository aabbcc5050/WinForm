using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                checked
                {
                    int Inum1;
                    int Inum2;
                    int Num;
                    Inum1 = 60000000;
                    Inum2 = 60000000;
                    Num = Inum1 * Inum2;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("引发了 OverflowException异常");
            }
            Console.ReadLine();
        }
    }
}
