using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var rad = Double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Round(rad * 180 / Math.PI, 0));
        }
    }
}
