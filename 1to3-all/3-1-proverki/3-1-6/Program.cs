using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var points = int.Parse(Console.ReadLine());
            double bonus = 0;
            double addbonus = 0;
           
            if (points<=100)
            {
                bonus = 5;
            }
            else if (points<=1000)
            {
                bonus = points * 0.2;
            }
            else
            {
                bonus = points * 0.1;
            }
            if (points % 2 == 0)
            {
                addbonus = addbonus + 1;
            }
            if ( points % 5 == 0 && points % 2 != 0)
            {
                addbonus = addbonus + 2;
            }
            Console.WriteLine(bonus+addbonus);
            Console.WriteLine(points+bonus+addbonus);
        }
    }
}
