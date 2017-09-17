using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(new ThreadStart(Thread1));
            thread1.Priority = ThreadPriority.Lowest;
            Thread thread2 = new Thread(new ThreadStart(Thread2));
            thread1.Start();
            thread2.Start();
            Thread.Sleep(1000);
        }

        static void Thread1() {
            Console.WriteLine("线程1");
        }

        static void Thread2()
        {
            Console.WriteLine("线程2");
        }
    }
}
