using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "square":
                    var h = double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.Pow(h, 2));
                    break;
                case "rectangle":
                    var h1 = double.Parse(Console.ReadLine());
                    var h2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(h1*h2);
                    break;
                case "circle":
                    var r = double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.PI *Math.Pow(r, 2));
                    break;
                case "triangle":
                    var a = double.Parse(Console.ReadLine());
                    var htr = double.Parse(Console.ReadLine());
                    Console.WriteLine(a*htr/2);
                    break;
            }
        }
    }
}
