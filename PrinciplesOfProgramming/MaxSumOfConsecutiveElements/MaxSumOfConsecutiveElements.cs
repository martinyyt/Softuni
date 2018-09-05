using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSumOfConsecutiveElements
{
    class MaxSumOfConsecutiveElements
    {
        static void Main(string[] args)
        {
            
            var n = int.Parse(Console.ReadLine()); //размер на масив
            var k = int.Parse(Console.ReadLine()); //колко елемента да се сумират

            int[] arr = new int[n];
            int maxSum = int.MinValue;
            int tempSum;

            for (int i = 0; i < arr.Length-1; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n-k+1; i++)
            {
                tempSum = 0;

                for (int j = i; j <i+ k; j++)
                {
                    tempSum += arr[j];
                }
                if (tempSum>maxSum)
                {
                    maxSum = tempSum;
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
