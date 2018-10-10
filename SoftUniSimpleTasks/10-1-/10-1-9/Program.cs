using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_9
{
    class Program
    {
        static double GetMin(double a, double b)
        {
            if (a<b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        static void Main(string[] args)
        {
            var num1 = double.Parse(Console.ReadLine());
            var num2 = double.Parse(Console.ReadLine());
            var num3 = double.Parse(Console.ReadLine());
            var min = GetMin(GetMin(num1, num2), num3);
            Console.WriteLine(min);

        }
    }
}
