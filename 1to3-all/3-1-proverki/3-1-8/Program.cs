using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Double count = Double.Parse(Console.ReadLine());
            var inx = Console.ReadLine();
            var outx = Console.ReadLine();
            Double mtrs = 0;
            if (inx == "m")
            {
                mtrs = count;
            }
            else if (inx == "mm")
            {
                mtrs = count / 1000;
            }
            else if (inx == "cm")
            {
                mtrs = count / 100;
            }
            else if (inx == "mi")
            {
                mtrs = count / 0.000621371192;
            }
            else if (inx == "in")
            {
                mtrs = count / 39.3700787;
            }
            else if (inx == "km")
            {
                mtrs = count / 0.001;
            }
            else if (inx == "ft")
            {
                mtrs = count / 3.2808399;
            }
            else if (inx == "yd")
            {
                mtrs = count / 1.0936133;
            }
            if (outx == "m")
            {
                Console.WriteLine(mtrs);
            }
            else if (outx == "mm")
            {
                Console.WriteLine(mtrs*1000);
            }
            else if (outx == "cm")
            {
                Console.WriteLine(mtrs * 100);
            }
            else if (outx == "mi")
            {
                Console.WriteLine(mtrs * 0.000621371192);
            }
            else if (outx == "in")
            {
                Console.WriteLine(mtrs * 39.3700787);
            }
            else if (outx == "km")
            {
                Console.WriteLine(mtrs * 0.001);
            }
            else if (outx == "ft")
            {
                Console.WriteLine(mtrs * 3.2808399);
            }
            else if (outx == "yd")
            {
                Console.WriteLine(mtrs * 1.0936133);
            }            
        }
    }
}
