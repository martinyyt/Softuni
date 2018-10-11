using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_proverki
{
    class Program
    {
        static void Main(string[] args)
        {
            var grade = Double.Parse(Console.ReadLine());
            if (grade>=5.5)
            {
                Console.WriteLine("Excellent!");
            }
            else
            {
             //   Console.WriteLine("Not Excellent");
            }
        }
    }
}
