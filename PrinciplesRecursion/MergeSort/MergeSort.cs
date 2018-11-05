using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingMethods
{
    public class MergeSort
    {
        private static void MergeSortedPartsOfArray(int[] toSort, int startIndex, int endIndex, int[] sorted) // 0, 2, 4
        {
            int leftStart = startIndex;
            int rightEnd = endIndex;
            int leftEnd = (rightEnd - leftStart) / 2 + leftStart;
            int rightStart = leftEnd + 1;

            for (int i = leftStart; i <= rightEnd; i++)
            {
                if (leftStart <= leftEnd &&
                    (rightStart > rightEnd || toSort[leftStart] <= toSort[rightStart])) //important sequence of "OR"
                {
                    sorted[i] = toSort[leftStart++];
                }
                else
                {
                    sorted[i] = toSort[rightStart++];
                }
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                toSort[i] = sorted[i];
            }
        }

        private static void DivideArray(int[] arrToSort, int startIndex, int endIndex)
        {
            int[] sortedArray = new int[arrToSort.Length];

            if (endIndex - startIndex > 1)
            {
                DivideArray(arrToSort, startIndex, (startIndex + endIndex) / 2);
                DivideArray(arrToSort, (startIndex + endIndex) / 2 + 1, endIndex);
            }

            MergeSortedPartsOfArray(arrToSort, startIndex, endIndex, sortedArray);

        }

        public static void Sort(int[] arrToSort)
        {
            DivideArray(arrToSort, 0, arrToSort.Length - 1);
        }

        static void Main(string[] args)
        {
            int[] arr = { 7, 1, 5, 3, 2, 0, 11, 15, 18, 32, -5, 99, -6, 1 };
            //int[] result = new int[arr.Length];
            //MergeSortedPartsOfArray(arr, 1, 3, result);  // 0, (length-1)/2, length-1 // startIndex, (endIndex-startIndex)/2+startIndex, endIndex
            Sort(arr);
            //Console.WriteLine(string.Join("; ",result));
            Console.WriteLine(string.Join("; ", arr));
        }
    }
}
