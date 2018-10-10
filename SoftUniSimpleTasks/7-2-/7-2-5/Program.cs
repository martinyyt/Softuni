using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 0;
            var printn = 0;
            do
            {
                 n = int.Parse(Console.ReadLine());
                 printn = n;
                if (n > 99 && n < 1000)
                {
                    break;
                }

            }
            while (true);
            var p3 = n % 10;
            var p2 = n / 10 % 10;
            var p1 = n / 100 % 10;
            var N = p1 + p2;
            var M = p1 + p3;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (n%5==0)
                    {
                        printn -= p1;
                    }
                    else if (n%3==0)
                    {
                        printn -= p2;
                    }
                    else //(n % 5 != 0&& n % 3 != 0)
                    {
                        printn += p3;
                    }
                    Console.Write(printn+" ");
                    n = printn;
                }
                Console.WriteLine();
            }
        }
    }
}
