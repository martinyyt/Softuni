using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SquareOf_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int i = 1; i < N - 1; i++)
            {
                Console.Write("*");
                for (int j = 1; j < N - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");            
            }
            for (int i = 1; i <= N; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
