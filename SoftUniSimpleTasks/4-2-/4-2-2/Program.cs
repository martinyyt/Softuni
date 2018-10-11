using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var budg = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var summer = "summer";
            var winter = "winter";
            var bulgaria = "Bulgaria";
            var balkans = "Balkans";
            var europe = "Europe";
            var camp = "Camp";
            var hotel = "Hotel";
            double exp = 0;
            string dest = "";
            string place = "";
            int perc = 0;
            if (budg >1000 && season == winter)
            {
                dest = europe; place = hotel; exp = Math.Round( budg * 0.9,2);
            }
            else if (budg <= 1000 && budg >100 && season == winter )
            {
                dest = balkans; place = hotel; exp = Math.Round(budg * 0.8, 2);
            }
            else if (budg <= 100 && season == winter)
            {
                dest = bulgaria; place = hotel; exp = Math.Round(budg * 0.7, 2);
            }
            else if (budg > 1000 && season == summer)
            {
                dest = europe; place = hotel; exp = Math.Round(budg * 0.9, 2);
            }
            else if (budg <= 1000 && budg > 100 && season == summer)
            {
                dest = balkans; place = camp; exp = Math.Round(budg * 0.4, 2);
            }
            else if (budg <= 100 && season == summer)
            {
                dest = bulgaria; place = camp; exp = Math.Round(budg * 0.3, 2);
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.WriteLine("Somewhere in {0}", dest);
            Console.WriteLine("{0} - {1}", place, exp.ToString("F2"));
        }
    }
}
