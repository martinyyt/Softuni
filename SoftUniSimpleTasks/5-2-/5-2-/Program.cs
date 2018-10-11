using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            for (int i = 0; i < n; i++)
            {
                double numb = double.Parse(Console.ReadLine());
                if (numb<200)
                {
                    p1 ++;
                }
                else if (numb<400)
                {
                    p2 ++;
                }
                else if (numb < 600)
                {
                    p3 ++;
                }
                else if (numb < 800)
                {
                    p4 ++;
                }
                else
                {
                    p5 ++;
                }
            }
            Console.WriteLine("{0:F2}%",p1/n*100);
            Console.WriteLine("{0:F2}%", p2 / n * 100);
            Console.WriteLine("{0:F2}%", p3 / n * 100);
            Console.WriteLine("{0:F2}%", p4 / n * 100);
            Console.WriteLine("{0:F2}%", p5 / n * 100);
        }
    }
}
