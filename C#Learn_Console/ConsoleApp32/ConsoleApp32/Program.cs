using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Program
    {
        public class Finder {
            public static int Find<T>(T[] items, T item) {
                for (int i=0;i<items.Length;i++) {
                    if (items[i].Equals(item)) {
                        return i;
                    }
                }
                return -1;
            }
        }

        static void Main(string[] args)
        {
            int[] arr1 = { 1,2,3,4,5,6};
            string[] arr2 = { "1","2","ss","sf"};
            int i = Finder.Find<int>(arr1, 5);
            int j = Finder.Find<string>(arr2, "ss");
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.ReadLine();
        }
    }
}
