using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n=int.Parse(Console.ReadLine());
            var numb = 100000;
            while (numb<=999999)
            {
                var n6 = numb % 10;
                var n5 = numb / 10 % 10;
                var n4 = numb / 100 % 10;
                var n3 = numb / 1000 % 10;
                var n2 = numb / 10000 % 10;
                var n1 = numb / 100000 % 10;
                if (n==n1*n2*n3*n4*n5*n6)
                {
                    Console.Write(numb+" ");
                }
                //Console.Write("{0}{1}{2}{3}{4}{5}",n1,n2,n3,n4,n5,n6);
                numb++;
            }
        }
    }
}
