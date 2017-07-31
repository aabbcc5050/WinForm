using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass2 my = new MyClass2();
            my.ID = "000";
            my.Name = "name";
            my.ShowInfo();
        }

        public class MyClass1
        {
            public virtual void ShowInfo() { }
        }

        public sealed class MyClass2 : MyClass1
        {
            private string id = "";
            private string name = "";
            public string ID { get; set; }
            public string Name { get; set; }
            public sealed override void ShowInfo()
            {
                base.ShowInfo();
                Console.WriteLine(ID+" "+Name);
            }
        }
    }
}
