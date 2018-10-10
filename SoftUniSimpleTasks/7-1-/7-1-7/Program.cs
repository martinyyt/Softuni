using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            while (a!=0)
            {
                var newb = a;
                a = b % a;
                b = newb;
            }
            Console.WriteLine(b);
        }
    }
}
