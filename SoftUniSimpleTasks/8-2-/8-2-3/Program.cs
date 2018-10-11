using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var br_hr = int.Parse(Console.ReadLine());
            var br_ro = int.Parse(Console.ReadLine());
            var br_la = int.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var holiday = Console.ReadLine();
            var buck = 2;
            var hr_winter = 3.75;
            var hr_sum = 2.0;
            var ro_winter = 4.5;
            var ro_sum = 4.1;
            var la_winter = 4.15;
            var la_sum = 2.5;
            var total = 0.0;

            if (season== "Spring"||season== "Summer")
            {
                total = br_hr * hr_sum + br_ro * ro_sum + br_la * la_sum;
            }
            else
            {
                total = br_hr * hr_winter + br_ro * ro_winter + br_la * la_winter;
            }
            if (holiday=="Y")
            {
                total *= 1.15;
            }
            if (br_la>7&&season=="Spring")
            {
                total *= 0.95;
            }
            if (br_ro > 10 && season == "Winter")
            {
                total *= 0.9;
            }
            if (br_hr+br_la+br_ro > 20)
            {
                total *= 0.8;
            }
            total += 2;
            Console.WriteLine("{0:F2}",total);
        }
    }
}
