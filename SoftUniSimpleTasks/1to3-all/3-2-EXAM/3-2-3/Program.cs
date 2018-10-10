using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int holidays = int.Parse(Console.ReadLine());
            int playmins = (365 - holidays) * 63 + holidays * 127;
            if (playmins>30000)
            {
                double diff = playmins - 30000;
               // Console.WriteLine(diff);
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play",Math.Floor(diff/60),diff%60);
            }
            else
            {
                double diff = 30000 - playmins;
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", Math.Floor(diff / 60), diff % 60);
            }
        }
    }
}
