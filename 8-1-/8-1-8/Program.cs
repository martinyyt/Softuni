using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_8
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count = 0;
            var countmax = 0;
            var oldnumb = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                var numb = int.Parse(Console.ReadLine());
                if (oldnumb<numb)
                {
                    count++;
                    if (count>=countmax)
                    {
                        countmax = count;
                    }
                }
                else
                {
                    count = 1;
                }
                oldnumb = numb;
            }
            Console.WriteLine(countmax);
        }
    }
}
