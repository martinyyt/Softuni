using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = Console.ReadLine().ToLower();
            //Console.WriteLine(city);
            var s = double.Parse(Console.ReadLine());
            if (city == "sofia")
            {
                if (0 <= s && s <= 500)
                {
                    Console.WriteLine(Math.Round(s * 0.05,2));
                }
                else if (500 < s && s <= 1000)
                {
                    Console.WriteLine(Math.Round(s * 0.07,2));
                }
                else if (1000 < s && s <= 10000)
                {
                    Console.WriteLine(Math.Round(s * 0.08,2));
                }
                else if (10000 < s)
                {
                    Console.WriteLine(Math.Round(s * 0.12,2));
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "varna")
            {
                if (0 <= s && s <= 500)
                {
                    Console.WriteLine(Math.Round(s * 0.045,2));
                }
                else if (500 < s && s <= 1000)
                {
                    Console.WriteLine(Math.Round(s * 0.075,2));
                }
                else if (1000 < s && s <= 10000)
                {
                    Console.WriteLine(Math.Round(s * 0.1,2));
                }
                else if (10000 < s)
                {
                    Console.WriteLine(Math.Round(s * 0.13,2));
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (city == "plovdiv")
            {
                if (0 <= s && s <= 500)
                {
                    Console.WriteLine(Math.Round(s * 0.055,2));
                }
                else if (500 < s && s <= 1000)
                {
                    Console.WriteLine(Math.Round(s * 0.08,2));
                }
                else if (1000 < s && s <= 10000)
                {
                    Console.WriteLine(Math.Round(s * 0.12,2));
                }
                else if (10000 < s)
                {
                    Console.WriteLine(Math.Round(s * 0.145,2));
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
