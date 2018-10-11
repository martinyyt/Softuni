using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            var a = decimal.Parse(Console.ReadLine());
            Console.Write("b=");
            var b = decimal.Parse(Console.ReadLine());
            Console.Write("liceto e ");
            Console.WriteLine(a * b);
        }
    }
}
