using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_6
{
    class Program
    {
        static double pow1(double x, double n)
        {
            return Math.Pow(x, n);
        }
        static void Main(string[] args)
        {
            var numb = double.Parse(Console.ReadLine());
            var pow = double.Parse(Console.ReadLine());
            Console.WriteLine(pow1(numb,pow));
        }
    }
}
