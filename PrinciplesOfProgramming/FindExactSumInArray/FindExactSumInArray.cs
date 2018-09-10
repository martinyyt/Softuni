using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_Methods;

namespace FindExactSumInArray
{
    class FindExactSumInArray
    {

        static void Variations(int[] arr, int[] output, int numberOfElements, int target)
        {
            int sum = 0;
            if (numberOfElements == 0)
            {
                for (int i = 0; i < output.Length; i++)
                {
                    sum += output[i];
                }
                if (sum==target)
                {
                    Methods.DisplayArray(output);
                    return;
                }
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                output[numberOfElements - 1] = arr[i];
                Variations(arr, output, numberOfElements - 1,target);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 2, 4, 3, 180, 2, 6 };
            var len = arr.Length;
            var target = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= arr.Length; i++)
            {
                int[] sum = new int[i];
                Variations(arr, sum, i,target);
            }

        }
    }
}
