using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            bool isprime = true;
            //Console.WriteLine(Math.Sqrt(n));
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n%i==0)
                {
                    isprime = false;
                    break;
                }
            }
            //Console.WriteLine(isprime);
            if (isprime && n>1)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
