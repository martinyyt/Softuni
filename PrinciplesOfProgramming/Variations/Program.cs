using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_Methods;

namespace Variations
{
    class Program
    {
        static void Variations(int[] arr, int[] output, int numberOfElements)
        {
            if (numberOfElements == 0)
            {
                Methods.DisplayArray(output);
                return;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                output[numberOfElements - 1] = arr[i];
                Variations(arr, output, numberOfElements - 1);                
            }
            
        }

        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            //int n = int.Parse(Console.ReadLine());
            int[] arr = { 1, 2, 3, 4, 5 };
            int n = arr.Length;
            int[] variation = new int[k];

            Variations(arr, variation, k);
            

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    variation[0] = arr[i];
            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        variation[1] = arr[j];
            //        for (int c = 0; c < arr.Length; c++)
            //        {
            //            variation[2] = arr[c];
            //            _1_Methods.Methods.DisplayArray(variation);
            //        }
            //    }
            //}

        }
    }
}
