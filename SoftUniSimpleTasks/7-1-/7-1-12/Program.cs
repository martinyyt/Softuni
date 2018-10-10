using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_12
{
    class Program
    {
        static void Main(string[] args)
        {
            bool breakk = false;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 3; j >=1 ; j--)
                {
                    if (i+j!=2)
                    {
                        Console.WriteLine(i+" "+j);
                    }
                    else
                    {
                        breakk = true;

                        break;
                    }
                }
                if (breakk)
                {
                    break;
                }
            }
        }
    }
}
