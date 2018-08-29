using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var col = 4 * n + 1;
            var row = 2 * n + 5;
            var point = (col - 3)/2;
            var dash = (col - 2*point - 3)/2;
            //Console.WriteLine(dash);
            Console.WriteLine("{0}/|\\{0}",new string('.',point));
            Console.WriteLine("{0}\\|/{0}", new string('.', point));
            for (int i = 0; i < row-5; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', point), new string('-', dash));
                point--;
                dash = (col - 2 * point - 3) / 2;
            }
            Console.WriteLine(new string('*', col));
            for (int i = 0; i < col; i++)
            {
                if (i%2==0)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
            Console.WriteLine(new string('*', col));
        }
    }
}
