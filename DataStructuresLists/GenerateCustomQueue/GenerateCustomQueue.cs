using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountOccurancesPlusStuff;

namespace GenerateCustomQueue
{
    class GenerateCustomQueue
    {
        static List<int> GenerateList(int startNumber, int elementsCount)
        {
            List<int> numbers = new List<int>();
            numbers.Add(startNumber);
            int currentNumber = startNumber;
            int counter = 1;
            while (numbers.Count<=elementsCount)
            {                
                numbers.Add(currentNumber + 1);
                if (numbers.Count==elementsCount)
                {
                    break;
                }
                numbers.Add(currentNumber * 2 + 1);
                if (numbers.Count == elementsCount)
                {
                    break;
                }
                numbers.Add(currentNumber + 2);

                currentNumber = numbers[counter++];
            }
            return numbers;
        }
        static void Main(string[] args)
        {
            int number = 2;
            int count = 50;
            List<int> numbers = GenerateList(number,count);
            foreach (var element in numbers)
            {
                Console.Write(element+"; ");
            }
            Console.WriteLine();
            Console.WriteLine(numbers.Count);
        }
    }
}
