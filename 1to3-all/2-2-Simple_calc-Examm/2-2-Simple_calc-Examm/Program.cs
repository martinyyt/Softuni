using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var l = Double.Parse(Console.ReadLine());
            var w = Double.Parse(Console.ReadLine());
            var countL = Math.Floor(l / 1.2);
            var countW = Math.Floor((w - 1) / 0.7);
            Console.WriteLine(countL*countW-3);
        }
    }
}
