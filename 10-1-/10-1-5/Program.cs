using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_5
{
    class Program
    {
        static double area_tr(double a, double h)
        {
            return a * h / 2;
        }
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            Console.WriteLine(area_tr(a,h));
        }
    }
}
