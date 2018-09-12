using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinations
{
    class Combinations
    {
        static int numberOfLoops;
        static int numberOfIterations;
        static int[] combination;

        static void NestedLoops(int currentLoop)
        {
            if (currentLoop == numberOfLoops)
            {
                for (int i = 0; i < numberOfLoops; i++)
                {
                    Console.Write("{0,4}", combination[i]);
                }
                Console.WriteLine();
                return;
            }

            for (int i = 1; i <= numberOfIterations; i++)
            {
                if (currentLoop != 0)
                {
                    if (combination[currentLoop - 1] > i)
                    {
                        continue;
                    }
                }

                combination[currentLoop] = i;
                NestedLoops(currentLoop + 1);
            }
        }

        static void Main(string[] args)
        {
            numberOfLoops = int.Parse(Console.ReadLine());
            numberOfIterations = int.Parse(Console.ReadLine());
            combination = new int[numberOfLoops];

            NestedLoops(0);
        }
    }
}
