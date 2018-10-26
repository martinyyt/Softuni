using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomSort
{
    class CustomSort
    {
        static List<int> SortByOccurancesThenByValue(List<int> arr)
        {
            Dictionary<int, int> countedElements = new Dictionary<int, int>();
            foreach (var number in arr)
            {
                if (countedElements.TryGetValue(number, out int value))
                {
                    countedElements[number] = value+1;
                }
                else
                {
                    countedElements.Add(number, 1);
                }
            }

            var sorted = countedElements.OrderBy(x => x.Value).ThenBy(x=>x.Key);

            List<int> sortedArr = new List<int>();

            foreach (var keyValuePair in sorted)
            {
                for (int i = 0; i < keyValuePair.Value; i++)
                {
                    sortedArr.Add(keyValuePair.Key);                    
                }
            }

            return sortedArr;
        }


        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 4, 8, 6, 2, 1, 4, 56, 9, 0, 5, 645, 8, 6, 6, 4, 5, 52, 4, 7, 8, 3, 4 };
            List<int> sorted = SortByOccurancesThenByValue(arr);
            foreach (var numb in sorted)
            {
                Console.WriteLine(numb);
            }
        }
    }
}
