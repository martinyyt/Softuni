using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_11
{
    class Program
    {
        static int FindNthDigit(int number, int index)
        {
            var currIndex = 1;
            
            while (number!=0)
            {
                var currNumber = number % 10;
                if (currIndex==index)
                {
                    return currNumber;
                    
                }
                else
                {
                    number /= 10;
                }
                currIndex += 1;
            }
            return 0;
        }

        static void Main(string[] args)
        {
            var numb = int.Parse(Console.ReadLine());
            var ind = int.Parse(Console.ReadLine());
            Console.WriteLine(FindNthDigit(numb, ind));
        }
    }
}
