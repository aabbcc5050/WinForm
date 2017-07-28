using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {
            ImyInterface myclass = new MyClass();
            myclass.ID = "TM";
            myclass.Name = "C#学习";
            myclass.ShowInfo();
            Console.ReadLine();
        }

        interface ImyInterface {
            string ID { get; set; }
            string Name { get; set; }
            void ShowInfo(); 
        }

        class MyClass : ImyInterface
        {
            string id = "";
            string name = "";
            public string ID { get =>  id;  set => id = value; }
            public string Name { get => name; set => name = value; }

            public void ShowInfo()
            {
                Console.WriteLine("编号\t姓名");
                Console.WriteLine(ID+"\t"+Name);
            }
        }
    }
}
