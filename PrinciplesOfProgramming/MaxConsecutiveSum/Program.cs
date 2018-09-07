using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_Methods;

namespace MaxConsecutiveSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, -21, 5, 0, 7, 6, -5, 21, 0, 0, 0, 0, -6, -5 };
            int maxSum=arr[0];
            int tempSum;
            int startIndex=0;
            int endIndex=0;

            for (int i = 0; i < arr.Length; i++)
            {
                int[] sum = new int[arr.Length  - i];
                sum[0] = arr[i];                
                tempSum = sum[0];
                var tempStartIndex = 0;
                var tempEndIndex = 0;

                for (int j = 1; j < sum.Length; j++)
                {
                    sum[j] = sum[j - 1] + arr[j + i];
                    if (sum[j]>=tempSum)
                    {
                        tempSum = sum[j];
                        tempStartIndex = i;
                        tempEndIndex = i + j;
                    }
                }

                if (tempSum>maxSum)
                {
                    maxSum = tempSum;
                    startIndex = tempStartIndex;
                    endIndex = tempEndIndex;

                }
                //Methods.DisplayArray(sum);
                //Console.WriteLine();
                //Console.WriteLine(startIndex);
                //Console.WriteLine(endIndex);
                //break;                      

            }
            int[] result = new int[endIndex - startIndex + 1];
            for (int i = startIndex; i <= endIndex; i++)
            {
                result[i - startIndex] = arr[i];
            }

            Methods.DisplayArray(result);
            Console.WriteLine();
            Console.WriteLine(maxSum);
            Console.WriteLine(startIndex);
            Console.WriteLine(endIndex);
        }
    }
}
