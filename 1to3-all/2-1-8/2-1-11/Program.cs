using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var usd = Double.Parse(Console.ReadLine());            
            Console.WriteLine(Math.Round(usd* 1.79549, 2));
        }
    }
}
