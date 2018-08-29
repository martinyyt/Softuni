using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_3
{
    class Program
    {
        static void prinline(int end=1, int start=1)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                prinline(i);

            }
            for (int i = n; i > 0; i--)
            {
                prinline(i);
            }
        }
    }
}
