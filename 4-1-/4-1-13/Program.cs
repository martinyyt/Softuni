using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_13
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            var fig1 = ((0 < x && x < 3 * h) && (0 < y && y < h));
            var fig2 = ((h < x && x < 2 * h) && (0 < y && y < 4*h));
            var out1 = (x<0 || x >3*h) || (0>y || y>h);
            var out2 = (h > x || x > 2 * h) || (0 > y || y > 4 * h);
            if ( fig1 || fig2)
            {
                Console.WriteLine("inside");
            }
            else if (out1 && out2)
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}
