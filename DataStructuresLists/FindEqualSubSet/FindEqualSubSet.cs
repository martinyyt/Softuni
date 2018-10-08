using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindEqualSubSet
{
    class FindEqualSubSet
    {
        static List<int> FindSubSet(List<int> numbers)
        {
            int startIndex = 0;
            int endIndex = 0;
            int length = 0;
            int maxLength = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                length = 0;
                for (int j = i; j < numbers.Count; j++)
                {                    
                    if (numbers[i] == numbers[j])
                    {
                        length++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (length > maxLength)
                {
                    startIndex = i;
                    endIndex = i + length;
                    maxLength = length;
                }
            }
            List<int> result = new List<int>();
            for (int i = startIndex; i < endIndex; i++)
            {
                result.Add(numbers[i]);
            }
            return result;
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 5, 5, 2, 2 };
            List<int> result = FindSubSet(numbers);
            foreach (var numb in result)
            {
                Console.WriteLine(numb);
            }
            
        }
    }
}
