using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(new ThreadStart(createThread));
            myThread.Start();          //启动线程
            myThread.Suspend();        //挂起线程
            myThread.Resume();         //恢复挂起的线程
            Thread.Sleep(1000);
        }

        public static void createThread() {
            Console.Write("创建新线程");
        }
    }
}
