using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var b1 = Double.Parse(Console.ReadLine());
            var b2 = Double.Parse(Console.ReadLine());
            var h = Double.Parse(Console.ReadLine());
            Console.WriteLine((b1 + b2) / 2 * h);
        }
    }
}
