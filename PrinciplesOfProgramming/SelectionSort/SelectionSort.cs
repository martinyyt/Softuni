using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            int[] arrayToSort = { 5, 21, 5, 0, 7, 6, 8, 21, 99, 0, 5, 2, 7, 33 };
            int temp;

            for (int i = 0; i < arrayToSort.Length-1; i++)
            {
                for (int j = i+1; j < arrayToSort.Length; j++)
                {
                    if (arrayToSort[i]>arrayToSort[j])
                    {
                        temp = arrayToSort[i];
                        arrayToSort[i] = arrayToSort[j];
                        arrayToSort[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arrayToSort.Length; i++)
            {
                Console.Write(arrayToSort[i]+" ");
            }

        }
    }
}
