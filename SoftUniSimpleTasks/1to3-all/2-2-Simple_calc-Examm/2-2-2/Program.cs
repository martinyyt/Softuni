using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var pr_veg = Double.Parse(Console.ReadLine());
            var pr_fr = Double.Parse(Console.ReadLine());
            var kg_veg = Double.Parse(Console.ReadLine());
            var kg_fr = Double.Parse(Console.ReadLine());
            Console.WriteLine(pr_veg * kg_veg / 1.94 + pr_fr * kg_fr / 1.94);
        }
    }
}
