using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 0; i <= 2*n-1; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i<=n-1)
                {
                    sum1 += number;
                }
                else
                {
                    sum2 += number;
                }
            }
            //int diff = num1 - num2;
            if (sum1==sum2)
            {
                Console.WriteLine("Yes, sum = {0}",sum1);
            }
            else
            {
                Console.WriteLine("No, diff = {0}",Math.Abs(sum1-sum2));
            }
        }
    }
}
