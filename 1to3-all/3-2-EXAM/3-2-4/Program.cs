using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            double y = Double.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double wine = x * y / 2.5 * 0.4;
                if (wine < z)
            {
                double diff = z - wine;
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(diff));
            }
                else
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling( wine-z), Math.Ceiling((wine-z)/n));
            }
        }
    }
}
