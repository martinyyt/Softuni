using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = Double.Parse(Console.ReadLine());
            var W = Double.Parse(Console.ReadLine());
            var L = Double.Parse(Console.ReadLine());
            var M = Double.Parse(Console.ReadLine());
            var O = Double.Parse(Console.ReadLine());
            Double count = (N * N - M * O) / (W * L);
            Console.WriteLine((N* N -M*O) /(W*L));
            Console.WriteLine(count*0.2);
        }
    }
}
