using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_2
{
    class Program
    {
        static void Ispositive(int n)
        {
            if (n>0)
            {
                Console.WriteLine("The number {0} is positive.",n);
            }
            else if (n < 0)
            {
                Console.WriteLine("The number {0} is negative.", n);
            }
            else
            {
                Console.WriteLine("The number 0 is zero.");
            }
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Ispositive(n);
        }
    }
}
