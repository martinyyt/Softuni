using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            if (m<45)
            {
                Console.WriteLine(h+":"+(m+15));
                         }
            else if (m<55)
            {
                Console.WriteLine((h+1) % 24 +":0"+(m+15-60));
            }
            else
            {
                Console.WriteLine((h + 1) % 24 + ":" + (m + 15 - 60));
            }
            
        }
    }
}
