using _1_Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class InsertionSort
    {
        static void DisplayArray1(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void Main(string[] args)
        {
            int[] arrayToSort = { 5, 21, 5, 0, 7, 6, 8, 21, 99, 0, 5, 2, 7, 33 };

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                int index = i;
                while (index > 0 && arrayToSort[index] < arrayToSort[index - 1])
                {
                    int temp = arrayToSort[index];
                    arrayToSort[index] = arrayToSort[index - 1];
                    arrayToSort[index - 1] = temp;
                    index--;
                }
            }
            //DisplayArray1(arrayToSort);

            _1_Methods.Methods.DisplayArray(arrayToSort);


            //for (int i = 0; i < arrayToSort.Length; i++)
            //{
            //    Console.Write(arrayToSort[i] + " ");
            //}

        }
    }
}
