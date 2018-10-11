using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int empl = int.Parse(Console.ReadLine());
            var workdays = days * 0.9;
            var workhours = workdays * 8*empl+workdays*2*empl;
            if (hours<=workhours)
            {
                Console.WriteLine("Yes!{0} hours left.", Math.Floor(workhours-hours));
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", Math.Floor(-workhours + hours));
            }
        }
    }
}
