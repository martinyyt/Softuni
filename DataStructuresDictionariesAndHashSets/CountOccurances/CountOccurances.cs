using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOccurances
{
    class CountOccurances
    {
        static SortedDictionary<int, int> CountOcc(List<int> list)
        {
            SortedDictionary<int, int> result = new SortedDictionary<int, int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (result.TryGetValue(list[i], out int value))
                {
                    result[list[i]] = value + 1;
                }
                else
                {
                    result.Add(list[i], 1);
                }
            }
            return result;
        }
        static List<int> RemoveOddOcc(SortedDictionary<int,int> counted)
        {
            List<int> reducedList = new List<int>();
            foreach (var keyValue in counted)
            {
                if (keyValue.Value%2==0)
                {
                    reducedList.Add(keyValue.Key);
                }
            }
            return reducedList;
        }
        static void Main(string[] args)
        {
            List<int> array = new List<int> { 3, 4, 4, 2, 3, 3, 4, 3, 2,  4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2,  6, 6 };
            SortedDictionary<int, int> occurances = CountOcc(array);
            foreach (var keyValue in occurances)
            {
                Console.WriteLine(keyValue);
            }
            Console.WriteLine();

            List<int> onlyEvenOccurances = RemoveOddOcc(occurances);
            foreach (var item in onlyEvenOccurances)
            {
                Console.Write("{0,3};",item);
            }
            Console.WriteLine();


        }
    }
}
