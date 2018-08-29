using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var R = Double.Parse(Console.ReadLine());
            //Console.WriteLine(2 * Math.PI * R);
            Console.WriteLine(Math.PI * Math.Pow(R,2));
            Console.WriteLine(2 * Math.PI * R);
        }
    }
}
