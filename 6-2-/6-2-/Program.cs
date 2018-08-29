using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var colsize = n / 2;
            var midsize =  2*n -2*colsize - 4;
            if (midsize<0)
            {
                midsize = 0;
            }
            
                Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', colsize), new string('_', midsize));//dali e taka???
            
            for (int i = 0; i < n-3; i++)
            {
                
                Console.WriteLine("|{0}|", new string(' ', 2 * n - 2));
            }
            
            
                Console.WriteLine("|{0} {1} {0}|", new string(' ', colsize), new string('_', midsize));//dali e taka???
            
            Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', colsize), new string(' ', midsize));
        }
    }
}
