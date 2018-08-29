using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = Double.Parse(Console.ReadLine());
            var y1 = Double.Parse(Console.ReadLine());
            var x2 = Double.Parse(Console.ReadLine());
            var y2 = Double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Abs(x1 - x2)*Math.Abs(y1 - y2));
            Console.WriteLine(Math.Abs(x1 - x2)*2 + Math.Abs(y1 - y2)*2);
        }
    }
}
