using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //start 11:20 / stop 12:00
            var speed = int.Parse(Console.ReadLine());
            var time1 = int.Parse(Console.ReadLine());
            var time2 = int.Parse(Console.ReadLine());
            var time3 = int.Parse(Console.ReadLine());
            var newsp = (double)speed;
            var h1 = time1 / 60.0;
            var h2 = time2 / 60.0;
            var h3 = time3 / 60.0;
            var dist = newsp * h1;
            newsp = newsp * 1.1;
            dist += newsp * h2;
            newsp = newsp * 0.95;
            dist += newsp * h3;
            Console.WriteLine("{0:F2}",dist);
        }
    }
}
