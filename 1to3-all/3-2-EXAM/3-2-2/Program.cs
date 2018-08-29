using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double H = Double.Parse(Console.ReadLine());
            double p1l = H * p1;
            double p2l = H * p2;
            double suml = p1l + p2l;
            if (V >= suml)
            {
                Console.WriteLine("The pool is " + Math.Floor(suml / V * 100) + "% full. Pipe 1: " + Math.Floor(p1l / suml * 100) + "%. Pipe 2: " + Math.Floor(p2l / suml * 100) + "%.");
            }
            else
            {
                Console.WriteLine("For "+H+" hours the pool overflows with "+(suml-V)+" liters.");
            }
        }
    }
}
