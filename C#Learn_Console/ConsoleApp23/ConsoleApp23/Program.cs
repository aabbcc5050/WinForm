using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myclass = new MyClass();
            myclass.Name = "TM";
            myclass.Sex = "男";
            myclass.teach();
            myclass.study();
            Console.ReadLine();
        }

        interface IPeople
        {
            string Name { get; set; }
            string Sex { get; set; }
        }

        interface ITeacher : IPeople
        {
            void teach();
        }

        interface IStudent : IPeople
        {
            void study();
        }

        class MyClass : IPeople, ITeacher, IStudent
        {
            string name = "";
            string sex = "";

            public string Name { get => name; set => name=value; }
            public string Sex { get => sex; set => sex=value; }

            public void study()
            {
                Console.WriteLine(Name+" "+Sex+" 教师");
            }

            public void teach()
            {
                Console.WriteLine(Name + " " + Sex + " 学生");
            }
        }
    }
}
