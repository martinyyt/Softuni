using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinationsOfArrayElements
{
    class CombinationsOfArrayElements
    {
        static int numberOfLoops;
        static int numberOfIterations;
        static int[] combination;

        static void NestedLoops(int currentLoop, params string[] arr)
        {
            if (currentLoop == numberOfLoops)
            {
                for (int i = 0; i < numberOfLoops; i++)
                {
                    Console.Write("{0} ", arr[combination[i]]);
                }
                Console.WriteLine();
                //Console.WriteLine(string.Join("; ",arr));
                return;
            }

            for (int i = 0; i < numberOfIterations; i++)
            {
                if (currentLoop != 0)
                {
                    if (combination[currentLoop - 1] >= i)  //without repetition of elements
                    {
                        continue;
                    }
                }

                combination[currentLoop] = i;
                NestedLoops(currentLoop + 1,arr);
            }
        }
        static void Main(string[] args)
        {
            string[] arr = { "one", "two", "three", "four", "five" };
            numberOfLoops = int.Parse(Console.ReadLine());
            numberOfIterations = arr.Length;
            combination = new int[numberOfLoops];

            NestedLoops(0,arr);
        }
    }
}
