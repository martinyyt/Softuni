using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine().ToLower();
            var r = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            switch (type)
                {
                case "premiere":
                    Console.WriteLine(Math.Round(c*r*12.0, 2)+" leva");
                    break;
                case "normal":
                    Console.WriteLine(Math.Round(c * r * 7.5, 2) + " leva");
                    break;
                case "discount":
                    Console.WriteLine(Math.Round(c * r * 5.0, 2) + " leva");
                    break;
            }
        }
    }
}
