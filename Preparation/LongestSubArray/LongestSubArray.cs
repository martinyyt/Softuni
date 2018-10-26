using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubArray
{
    class LongestSubArray
    {
        static int CountLongestSubArray(List<int> numbers, int target)
        {
            int result = 0;

            for (int i = 0; i < numbers.Count - 1; i++)
            {
                int counter = 0;
                int sum = 0;
                if (numbers[i] <= target)
                {
                    counter = 1;
                    sum = numbers[i];
                }
                else
                {
                    continue;
                }
                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if (sum + numbers[j] <= target)
                    {
                        sum += numbers[j];
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (counter > result)
                {
                    result = counter;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 6, 1, 2, 5, 6, 8, 4, 2, 4 };
            int maxSum = 12;
            Console.WriteLine(CountLongestSubArray(numbers, maxSum));
        }
    }
}
