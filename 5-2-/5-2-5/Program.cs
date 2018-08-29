using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;
            var cp1 = 0.0;
            var cp2 = 0.0;
            var cp3 = 0.0;
            for (int i = 0; i < n; i++)
            {
                var vhod = int.Parse(Console.ReadLine());
                if (vhod%2==0)
                {
                    cp1++;
                }
                if (vhod % 3 == 0)
                {
                    cp2++;
                }
                if (vhod % 4 == 0)
                {
                    cp3++;
                }
            }
            p1 = cp1 / n * 100.0; //Console.WriteLine(cp1); Console.WriteLine(cp2);
            p2 = cp2 / n * 100.0;
            p3 = cp3 / n * 100.0;
            Console.WriteLine(p1.ToString("F2")+"%");
            Console.WriteLine(p2.ToString("F2") + "%");
            Console.WriteLine(p3.ToString("F2") + "%");
        }
    }
}
