using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_1_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string w1 = Console.ReadLine();
            string w2 = Console.ReadLine();
            if (w1.ToLower()==w2.ToLower())
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
