using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxLenghtIncreasingElements
{
    class MaxLenghtIncreasingElements
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int[] length = new int[n];
            var finalIndex = 0;

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                length[i] = 1;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        if (length[j] >= length[i])
                        {
                            length[i] = length[j] + 1;
                        }
                    }
                }
            }

            //Console.WriteLine(length.Max());
            for (int i = 0; i < n; i++)
            {
                if (length.Max() == length[i])
                {
                    finalIndex = i;
                    break;
                }
            }

            var resultLength = length.Max();

            Console.WriteLine("#" + finalIndex + " value" + resultLength); //само за справка
            int[] result = new int[resultLength];
            result[resultLength-1] = arr[finalIndex];


            for (int j = resultLength-2; j >= 0; j--)
            {
                for (int i = 0; i < n; i++)
                {
                    if (length[i] == j+1 && arr[i] < result[j + 1])
                    {
                        result[j] = arr[i];
                        break;
                    }
                }
            }


            for (int i = 0; i < resultLength; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
