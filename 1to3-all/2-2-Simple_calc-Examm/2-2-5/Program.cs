using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var M = Double.Parse(Console.ReadLine());
            var usdtolv = Double.Parse(Console.ReadLine());
            Double ysal = N * M * (12 + 2.5);
            Double net = ysal * 0.75;
            Double av = net / 365 * usdtolv;
            Console.WriteLine(Math.Round(av, 2));
        }
    }
}
