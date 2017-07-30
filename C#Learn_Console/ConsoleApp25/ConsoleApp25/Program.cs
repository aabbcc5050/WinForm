using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveClass drive = new DriveClass();
            drive.ID = "007";
            drive.Name = "007";
            drive.ShowInfo();
            Console.ReadLine();
        }

        public abstract class MyClass
        {
            private string id = "";
            private string name = "";
            public string ID { get; set; }
            public string Name { get; set; }
            public abstract void ShowInfo();
        }

        public class DriveClass : MyClass
        {
            public override void ShowInfo()
            {
                Console.WriteLine(ID+" "+Name);
            }
        }
    }
}
