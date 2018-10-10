using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine()); // x-1=1   x+1=3
            for (int i = 0; i < (n+1)/2; i++)
            {
                var line = i + 1;
                for (int j = 0; j < n; j++)
                {
                    var pos = j + 1; // roundup n/2 +1 - line
                    if (pos == (int)Math.Ceiling(n/2f) - line+1 || pos == (int)Math.Floor(n/2f) + line)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine();
            }
            for (int i = 0; i < (n-1)/2; i++)
            {
                //Console.WriteLine("!");
                var line = i + 1;
                for (int j = 0; j < n; j++)
                {
                    var pos = j + 1;
                    if (pos==n-line || pos == line+1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
