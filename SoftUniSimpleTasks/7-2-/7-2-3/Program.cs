using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var s = int.Parse(Console.ReadLine());
            while (n<=m)
            {
                if (m%2==0 && m%3==0)
                {
                    if (m==s)
                    {
                        break;
                    }
                    Console.Write(m+" ");
                }
                m--;
            }
        }
    }
}
