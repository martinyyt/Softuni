using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_12
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine().ToLower();
            var p = int.Parse(Console.ReadLine());
            var h = int.Parse(Console.ReadLine());
            double sof = ((3.0 / 4.0) * (48 - h) + (2.0 / 3.0) * p);
            double home = h;
            if (year == "leap")
            {
                Console.WriteLine(Math.Floor((sof+home)*1.15));
                //Console.WriteLine(sof);
                //Console.WriteLine(home);
                //Console.WriteLine(3/4);
            }
            else
            {
                Console.WriteLine(Math.Floor((sof + home)*1.0));
            }
            
        }
    }
}
