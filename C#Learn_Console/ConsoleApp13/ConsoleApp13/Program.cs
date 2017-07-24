using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = 'a';
            char b = '8';
            char c = 'L';
            char d = '.';
            char e = '|';
            char f = ' ';
            Console.WriteLine("isLetter方法判断{1}是否字母:{0}",char.IsLetter(a),a);
            Console.WriteLine("isDigit方法判断{1}是否为数字:{0}", char.IsDigit(b),b);
            Console.WriteLine("isLetterOrDigit方法判断{1}是否为字母或者数字:{0}", char.IsLetterOrDigit(c),c);
            Console.WriteLine("isLower方法判断{1}是否为小写字母:{0}", char.IsLower(a),a);
            Console.WriteLine("isUpper方法判断{1}是否为大写字母:{0}", char.IsUpper(c),c);
            Console.WriteLine("isPunctuation方法判断{1}是否为标点符号:{0}", char.IsPunctuation(d),d);
            Console.WriteLine("isSeparator方法判断{1}是否为分隔符:{0}", char.IsSeparator(e),e);
            Console.WriteLine("isWhiteSpace方法判断{1}是否为空白:{0}", char.IsWhiteSpace(f),f);
            Console.ReadLine();
        }
    }
}
