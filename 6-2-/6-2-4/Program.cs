using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            char diez = '#';
            char dot = '.';
            var middlediezcount = (n + 1) / 2;
            var upperdiezcount = n;
            var sidedotcount = n / 2;
            var middledotcount = n - 2;
            var upperlinecount = n - 2;
            var totalpos = 2*sidedotcount + n;
            Console.WriteLine("{0}{1}{0}", new string(dot, sidedotcount), new string(diez, upperdiezcount));
            for (int i = 0; i < upperlinecount; i++)
            {
                Console.WriteLine("{0}#{1}#{0}",new string(dot,sidedotcount), new string(dot, middledotcount));
            }
            Console.WriteLine("{0}{1}{0}", new string(diez, middlediezcount), new string(dot, middledotcount));
            
            sidedotcount = 1;
            middledotcount = totalpos - 2 * sidedotcount - 2;
            for (int i = 0; i < upperlinecount; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string(dot, sidedotcount), new string(dot, middledotcount));
                //Console.WriteLine(sidedotcount); Console.WriteLine(middledotcount); Console.WriteLine(totalpos);
                sidedotcount ++ ;
                middledotcount -= 2;
            }
            Console.WriteLine("{0}#{0}", new string(dot, sidedotcount));

        }
    }
}
