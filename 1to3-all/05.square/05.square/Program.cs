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
                if (i == 1 || i == N)
                {
                    for (int j = 1; j <= N - 2; j++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (int j = 1; j <= N - 2; j++)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("*");
            }
        }
    }
}
