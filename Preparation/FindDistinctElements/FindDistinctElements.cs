using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preparation
{
    class FindDistinctElements
    {
        static int CountDistinct (List<int> arr)
        {
            HashSet<int> distinctInts = new HashSet<int>();
            foreach (var numb in arr)
            {
                distinctInts.Add(numb);
            }
            return distinctInts.Count;
        }

        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 4, 8, 6, 2, 1, 4, 56, 9, 0, 5, 645, 8, 6, 6, 4, 5, 52, 4, 7, 8, 3, 4 };
            Console.WriteLine(CountDistinct(arr));
        }
    }
}
