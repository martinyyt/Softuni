using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Double.Parse(Console.ReadLine());
            var inr = (n >= 100 && n <= 200) || n == 0;
            Console.WriteLine(inr);
            if (!inr)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
