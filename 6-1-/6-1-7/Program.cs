using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <n-i; j++)
                {
                    Console.Write(" ");
                }
                for (int z = 0; z < i; z++)
                {
                    Console.Write("*");
                }
                Console.Write(" | ");
                for (int x = 0; x <i; x++)
                {
                    Console.Write("*");
                }
                for (int c = 0; c < n - i; c++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
