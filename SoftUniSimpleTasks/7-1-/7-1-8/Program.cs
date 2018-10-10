using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count = 0;
            var sum = 1;
            do
            {
                count++;
                sum *= count;
            } while (count<n);
            Console.WriteLine(sum);
        }
    }
}
