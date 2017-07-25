using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Hashtable hashtable = new Hashtable();
            list.Add(1);
            list.Add(2);
            list.Add("nihao a ");
            hashtable.Add("key1","value1");
            hashtable.Add("key2","value2");
            foreach (object obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine(hashtable);
            foreach (DictionaryEntry entry in hashtable) {
                Console.WriteLine(entry.Key+":"+entry.Value);
            }
            Console.WriteLine("hashtable[\"keyname\"]:"+hashtable["key1"]);
            hashtable.Clear();
            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine(entry.Key + ":" + entry.Value);
            }
            Console.ReadLine();
        }
    }
}
