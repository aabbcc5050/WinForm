using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass();
            myclass.ID = "BH001";
            myclass.Name = "TM1";
            Console.WriteLine(myclass.ID+" "+myclass.Name);
            myclass.ID = "BH002";
            myclass.Name = "TM2";
            Console.WriteLine(myclass.ID + " " + myclass.Name);
            Console.ReadLine();
        }
    }

    class MyClass {
        private string id = "";
        private string name = "";
        public string ID {
            get {return id;}
            set {id = value;}
        }
        public string Name {
            get { return name; }
            set { name = value; }
        }
    }
}
