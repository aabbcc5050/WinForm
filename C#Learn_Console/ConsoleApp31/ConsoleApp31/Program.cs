using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        public interface IgenericLnterface<T> {
            T CreateInstance();
        }

        public class MyFactory<T> : IgenericLnterface<T> where T:new()
        {
            public T CreateInstance()
            {
                return new T();
            }
        }

        public class Factory<T, TI> : IgenericLnterface<TI> where T : TI, new()
        {
            public TI CreateInstance()
            {
                return new T();
            }
        }

        static void Main(string[] args)
        {
            IgenericLnterface<System.ComponentModel.IListSource> factory =
                new Factory<System.Data.DataTable, System.ComponentModel.IListSource>();

            IgenericLnterface<Object> Myfactory =new MyFactory<Object>();
            Console.WriteLine(factory.CreateInstance().GetType().ToString());
            Console.WriteLine(Myfactory.CreateInstance().GetType().ToString());
            Console.ReadLine();
        }
    }
}
