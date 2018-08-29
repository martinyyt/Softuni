using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int sp = 1111; sp <= 9999; sp++)
            {
                var p4 = sp % 10;
                var p3 = sp / 10 % 10;
                var p2 = sp / 100 % 10;
                var p1 = sp / 1000 % 10;
                if (p1!=0&& p2 != 0 && p3 != 0 && p4 != 0)
                {

                
                if (n%p1==0 && n % p2 == 0&& n % p3 == 0&& n % p4 == 0)
                {
                    Console.Write(sp+" ");
                }
                    }
            }
        }
    }
}
