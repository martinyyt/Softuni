using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i <= n-1; i++)
            {
                int N = int.Parse(Console.ReadLine());
                sum +=N;
            }
            Console.WriteLine(sum);
        }
    }
}
