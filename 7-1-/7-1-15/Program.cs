using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_15
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var numb = 1;
            var line = 1;
            var pos = 1;
            while (true)
            {
                if (numb == n)
                {
                    Console.WriteLine(n);
                    break;
                }
                if (pos == line)
                {
                    Console.WriteLine(numb);
                    pos = 0;
                    line++;
                }
                else
                {
                    Console.Write(numb + " ");
                }
                numb++;
                pos++;
                
            }
        }
    }
}
