using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //start 14:40
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());
            var h = Math.Abs(y1 - y2);
            var osn = Math.Abs(x3 - x2);
            Console.WriteLine(h*osn/2);
        }
    }
}
