using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var lines = n + n / 2*2;
            //Console.WriteLine(lines);
            var rows = 3 * n+2*n;
            var leftdash = 3 * n;
            var leftstars = 3 * n;
            var middash = 0;
            var rightdash = rows - leftdash - 2 - middash;
            for (int i = 0; i < n; i++)
            {
                //var line = i + 1;
                Console.WriteLine("{0}*{1}*{2}",new string('-',leftdash), new string('-', middash),new string('-', rightdash));
                middash++;
                rightdash= rows - leftdash - 2 - middash;
            }
            middash--;
            rightdash++;
            for (int i = 0; i < n/2; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('*', leftdash), new string('-', middash), new string('-', rightdash));
            }
            //Console.WriteLine("{0}*{1}*{2}", new string('-', leftdash), new string('-', middash), new string('-', rightdash));
            //Console.WriteLine("{0}*{1}*{2}", new string('-', leftdash-1), new string('*', middash+2), new string('-', rightdash-1));
            for (int i = 0; i < n/2-1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}", new string('-', leftdash), new string('-', middash), new string('-', rightdash));
                middash+=2;
                leftdash--;
                rightdash = rows - leftdash - 2 - middash;
            }
            Console.WriteLine("{0}*{1}*{2}", new string('-', leftdash), new string('*', middash), new string('-', rightdash));
        }
    }
}
