using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var inches = Double.Parse(Console.ReadLine());
            var cm = inches * 2.54;
            Console.WriteLine(cm);
        }
    }
}
