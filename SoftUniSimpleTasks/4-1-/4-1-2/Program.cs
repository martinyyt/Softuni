using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var city = Console.ReadLine();
            
            var n = Double.Parse( Console.ReadLine());
            if (city == "Sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(n * 0.5);
                }
                else if (product == "water")
                {
                    Console.WriteLine(n * 0.8);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(n * 1.2);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(n * 1.45);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(n * 1.6);
                }
            }
            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(n * 0.4);
                }
                else if (product == "water")
                {
                    Console.WriteLine(n * 0.7);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(n * 1.15);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(n * 1.30);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(n * 1.5);
                }
            }
            else if (city=="Varna")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(n * 0.45);
                }
                else if (product == "water")
                {
                    Console.WriteLine(n * 0.7);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(n * 1.1);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(n * 1.35);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(n * 1.55);
                }
            }

        }
    }
}
