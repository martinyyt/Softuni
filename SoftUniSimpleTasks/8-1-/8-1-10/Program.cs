using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var lines = (n + 1) / 2 * 2 + 1;
            //Console.WriteLine(lines);
            var cols = 2 * n;
            Console.WriteLine(new string('%',cols));//gore

            //zapochvame sredata
            for (int i = 0; i < lines-2; i++)
            {
                var line = i + 1;
                // Console.WriteLine("!!");
                var space = (cols - 2)/2;
                var stars = 0;
                if (line==(lines-1)/2) //sredniq red
                {
                    stars = 2;
                    space = space - 1;
                }
                Console.WriteLine("%{0}{1}{0}%",new string(' ',space), new string('*', stars));
            }

            Console.WriteLine(new string('%', cols));//dolu
        }
    }
}
