
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine();
            var day = Console.ReadLine();
            var n = Double.Parse(Console.ReadLine());
            if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    Console.WriteLine(Math.Round( n*2.7,2));
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine(Math.Round(n * 1.25, 2));
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine(Math.Round(n * 0.9, 2));
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine(Math.Round(n * 1.6, 2));
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine(Math.Round(n * 3, 2));
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine(Math.Round(n * 5.6, 2));
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine(Math.Round(n * 4.2, 2));
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    Console.WriteLine(Math.Round(n * 2.5, 2));
                }
                else if (fruit == "apple")
                {
                    Console.WriteLine(Math.Round(n * 1.2, 2));
                }
                else if (fruit == "orange")
                {
                    Console.WriteLine(Math.Round(n * 0.85, 2));
                }
                else if (fruit == "grapefruit")
                {
                    Console.WriteLine(Math.Round(n * 1.45, 2));
                }
                else if (fruit == "kiwi")
                {
                    Console.WriteLine(Math.Round(n * 2.7, 2));
                }
                else if (fruit == "pineapple")
                {
                    Console.WriteLine(Math.Round(n * 5.5, 2));
                }
                else if (fruit == "grapes")
                {
                    Console.WriteLine(Math.Round(n * 3.85, 2));
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
