using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum1 =0;
            var sum2 =0;
            var sum3 =0;
            for (int i = 0; i < n; i++)
            {
                var numb = int.Parse(Console.ReadLine());
                var count = i + 1;
                if (count%3==1)
                {
                    sum1 += numb;
                }
                else if (count % 3==2)
                {
                    sum2 += numb;
                }
                else
                {
                    sum3 += numb;
                }
            }
            Console.WriteLine("sum1 = "+sum1);
            Console.WriteLine("sum2 = " + sum2);
            Console.WriteLine("sum3 = " + sum3);
        }
    }
}
