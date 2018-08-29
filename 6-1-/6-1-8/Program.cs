using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.Write(new string('*',2*n));
            Console.Write(new string(' ',n));
            Console.Write(new string('*', 2 * n));
            Console.WriteLine();
             // ||| трябва да се чертаят n на брой "|" ако реда е int (n-1)/2
            for (int i = 0; i < n-2; i++)
            {
                Console.Write("*");
                Console.Write(new string('/', 2*n-2));
                Console.Write("*");
                if (i==(n-1)/2-1)
                {
                    Console.Write(new string('|', n));
                   // Console.Write((n - 1) / 2-1);
                }
                else
                {
                    Console.Write(new string(' ',n));
                }
                Console.Write("*");
                Console.Write(new string('/', 2 * n - 2));
                Console.WriteLine("*");
            }
            Console.Write(new string('*', 2 * n));
            Console.Write(new string(' ', n));
            Console.Write(new string('*', 2 * n));
            Console.WriteLine();
        }
    }
}
