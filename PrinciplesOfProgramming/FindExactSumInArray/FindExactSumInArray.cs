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

        static void FindRequiredSumSubArray(int[] arr, int sum)
        {
            //create an array for the subset with max length of input array  
            int[] sub = new int[arr.Length];
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i, col = 0; j < arr.Length; j++, col++)
                {
                    //add the value of input array one by one  
                    temp += arr[j];
                    sub[col] = arr[j];
                    //if addition is equal to sum then print it  
                    if (temp == sum)
                    {
                        int total = 0;
                        for (int k = 0; k < sub.Length; k++)
                        {
                            total += sub[k];
                            Console.Write(sub[k].ToString() + " ");

                            //if total and sum are equal then leave the print  
                            if (total == sum)
                            {
                                Console.Write("\n");
                                break;
                            }
                        }
                    }
                    //if temp is greater than sum are equal then clear the sub array, set temp value and leave the loop for next  
                    if (temp > sum)
                    {
                        Array.Clear(sub, 0, sub.Length);
                        temp = 0;
                        break;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 2, 1, 2, 4, 3, 18, 2, 6 };
            var len = arr.Length;
            var sum = int.Parse(Console.ReadLine());

            Console.WriteLine("Output String is:");
            FindRequiredSumSubArray(arr, sum);
            Console.WriteLine();


        }
    }
}
