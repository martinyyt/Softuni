using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            // редове = 2*n+2
            // 3=>15 / 6=>27 символи на ред = 2*n+2+2*n+1 = 4*n+3
            var total_lines = 2 * n + 2;
            //var total_pos = 4 * n + 3;
            var dotcount = n + 1;
            var undercount = 2 * n + 1;
            var total_pos = 2*dotcount+undercount;
            Console.WriteLine("{0}{1}{0}", new string('.', dotcount), new string('_', undercount));
            for (int i = 0; i < n; i++)
            {
                dotcount--;
                undercount = total_pos - 2*dotcount - 4;
                Console.WriteLine("{0}//{1}\\\\{0}",new string('.',dotcount),new string('_',undercount));
            }
            //undercount =(undercount-3)/2;
            dotcount--;
            undercount = total_pos - 2 * dotcount - 4;
            Console.WriteLine("//{0}STOP!{0}\\\\", new string('_', (undercount-5)/2));
            for (int i = 0; i < n; i++)
            {
                
                Console.WriteLine("{0}\\\\{1}//{0}", new string('.', dotcount), new string('_', undercount));
                dotcount++;
                undercount = total_pos - 2 * dotcount - 4;
            }
        }
    }
}
