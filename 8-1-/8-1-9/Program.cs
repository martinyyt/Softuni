using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var total_col = (n - 1) * 2 + 1;
            for (int i = 0; i < n; i++)
            {
                var line = i + 1;
                var stars = line;
                var dash = line - 1;
                var middle = dash + stars;
                var space = (total_col - stars - dash)/2;
                Console.Write("{0}",new string(' ',space));
                for (int j = 1; j <= middle; j++)
                {
                    if (j%2==0)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine("{0}", new string(' ', space));
            }
            for (int i = 0; i < n-1; i++)
            {
                var line = i + 1;
                var stars = n-line;
                var dash = n-line - 1;
                var middle = dash + stars;
                var space = (total_col - stars - dash) / 2;
                Console.Write("{0}", new string(' ', space));
                for (int j = 1; j <= middle; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine("{0}", new string(' ', space));
            }
        }
    }
}
