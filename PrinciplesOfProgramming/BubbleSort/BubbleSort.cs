using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class BubbleSort
    {
        public static void Sort(List<int> arr)
        {
            var swapped = false;

            do
            {
                swapped = false;
                for (int i = 0; i < arr.Count-1; i++)
                {
                    if (arr[i]>arr[i+1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);
        }

        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 5, 9, 6, 2, 4, 8, 5, 9, 4, 5, 6, 2, 45, 8, 5, 6, 2, 4, 7, 5, 0, 1, 4, 8, 9 };
            Sort(arr);

            Console.WriteLine(string.Join("; ",arr));
        }
    }
}
