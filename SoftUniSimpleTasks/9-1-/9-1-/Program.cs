using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1_1
{
    class Program
    {
        static int TribNext(int tribFirst, int tribSecond, int tribThird)
        {
            var tribNew = tribFirst + tribSecond + tribThird;
            return tribNew;
        }

        static int SpiralNext(int spiralCurrent, int step)
        {
            var spiralNext = spiralCurrent + step;
            return spiralNext;
        }

        static void Main(string[] args)
        {
            var tribFirst = int.Parse(Console.ReadLine());
            var tribSecond = int.Parse(Console.ReadLine());
            var tribThird = int.Parse(Console.ReadLine());
            var spiralCurrent = int.Parse(Console.ReadLine());
            var spiralStep = int.Parse(Console.ReadLine());
            var tribNext = tribThird;
            var spiralNewStep = spiralStep;
            var spiralNext = spiralCurrent;
            //Console.WriteLine();

            for (int i = 0; true; i++)
            {

                spiralCurrent = spiralNext;
                spiralNewStep = spiralStep + i / 2 * spiralStep;
                spiralNext = SpiralNext(spiralCurrent, spiralNewStep);

                while (tribThird<=spiralCurrent)
                {

                    if (spiralCurrent == tribFirst || spiralCurrent == tribSecond || spiralCurrent == tribThird)
                    {

                        break;
                    }

                        tribNext = TribNext(tribFirst, tribSecond, tribThird);
                        tribFirst = tribSecond;
                        tribSecond = tribThird;
                        tribThird = tribNext;
                }
                
                //Console.WriteLine(spiralCurrent);
                //spiralCurrent = spiralNext;
                // Console.WriteLine(spiralNewStep);

                if (spiralCurrent>1000000||tribThird>1000000)
                {
                    Console.WriteLine("No");
                    break;
                }
                if (spiralCurrent == tribFirst || spiralCurrent == tribSecond || spiralCurrent == tribThird)
                {
                    Console.WriteLine(spiralCurrent);
                    break;
                }
            }
        }
    }
}
