using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var cash = double.Parse(Console.ReadLine());
            var h1_bath = double.Parse(Console.ReadLine());
            var h2_bath = double.Parse(Console.ReadLine());
            var side_pl = double.Parse(Console.ReadLine());
            var h_pl = double.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());
            var master_sum = double.Parse(Console.ReadLine());

            var area_bath = h1_bath * h2_bath;
            var area_pl = side_pl * h_pl / 2;
            var pl_needed = Math.Ceiling(area_bath / area_pl)+5;
            var cash_needed = pl_needed * price;
            var diff = cash - master_sum - cash_needed;
            if (diff>=0)
            {
                Console.WriteLine("{0:F2} lv left.",diff);
            }
            else
            {
                Console.WriteLine("You'll need {0:F2} lv more.",-diff);
            }
        }
    }
}
