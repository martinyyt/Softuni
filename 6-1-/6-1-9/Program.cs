using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var n2up = (n + 1) / 2;
            var n2down = n / 2;
            // покрива е n/2 реда roundup | последен ред n пъти * 
            // всички редове ROUNDup n/2-i "_" + n-roundup(n/2)+i "*" + ROUNDup n/2-i "_"
            //Console.WriteLine((n+1)/2);
            for (int i = 0; i < n2up; i++)
            {
                // Console.WriteLine("wtf");
                Console.Write(new string('-', n2up-i-1));
                Console.Write(new string('*', n-2*(n2up-i-1)));
                Console.WriteLine(new string('-', n2up - i-1));
            }
            for (int i = 0; i < n2down; i++)
            {
                Console.Write("|");
                Console.Write(new string('*',n-2));
                Console.WriteLine("|");
            }
        }
    }
}
