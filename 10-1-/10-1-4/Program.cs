using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_4
{
    class Program
    {
        static string topbottom(char ch, int n)
        {
            return new string(ch,2*n);
        }
        static void middle(char ch, int n)
        {
            Console.Write(ch);
            for (int i = 0; i < n-1; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine(ch);
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(topbottom('-', n));
            for (int i = 0; i < n-2; i++)
            {
                middle('-', n);
            }
            Console.WriteLine(topbottom('-', n));
        }
    }
}
