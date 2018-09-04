using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinciplesOfProgramming
{
    class MagicNumbersThreeLoops
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 0; b <= 9; b++)
                {
                    for (int c = 0; c <= 9; c++)
                    {
                        var d = (a + b) - c;
                        if (d <= 9 && d >= 0)
                        {
                            Console.WriteLine(" " + a + " " + b + " " + c + " " + d);
                        }

                    }
                }
            }
        }
    }
}
