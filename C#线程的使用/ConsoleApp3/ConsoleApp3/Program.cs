using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.lockThreadByLock();
            Thread.Sleep(1000);
        }

        void lockThreadByLock() {
            lock (this) {
                Console.WriteLine("锁定线程以实现线程同步");
            }
        }

        void lockThreadByMonitor()
        {
            Monitor.Enter(this);                             //锁定当前线程
            Console.WriteLine("锁定线程以实现线程同步");
            Monitor.Exit(this);                              //释放当前线程
        }

        void lockThreadByMutex()
        {
            Mutex myMutex = new Mutex(false);                
            myMutex.WaitOne();                               //阻止当前线程
            Console.WriteLine("锁定线程以实现线程同步");
            myMutex.ReleaseMutex();                          //释放mulex对象
        }
    }
}
