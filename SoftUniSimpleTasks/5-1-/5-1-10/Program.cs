using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sum = 0.0;
            var max = double.MinValue;
            for (int i = 0; i < n; i++)
            {
                var chislo = double.Parse(Console.ReadLine());
                sum += chislo;
                if (max<chislo)
                {
                    max = chislo;
                }
            }
            if (max == sum-max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}",max);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}",Math.Abs(sum-max-max));
            }
        }
    }
}
