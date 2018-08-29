using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_14
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var f1 = 1;
            var f2 = 1;
            var f3 = 0;
            for (int i = 0; i < n; i++)
            {
                f3 = f1 + f2;
                f1 = f2;
                f2 = f3;
            }
            Console.WriteLine(f1);
        }
    }
}
