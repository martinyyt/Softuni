using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2_2
{
    class Program
    {
        static int Fib(int n)
        {
            if (n<=2)
            {
                return 1;
            }
            return Fib(n - 1) + Fib(n - 2);
        }

        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(Fib(x));
            System.Math.Abs
        }
    }
}
