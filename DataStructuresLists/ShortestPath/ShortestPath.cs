using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortestPath
{
    class ShortestPath
    {
        static Dictionary<int, int> GenerateLinkedSteps(int start, int target)
        {
            Dictionary<int, int> linkedNumbers = new Dictionary<int, int>();

            //int currentNumb = start; // no need
            Queue<int> numbers = new Queue<int>();
            numbers.Enqueue(start);
            //int previousStep = 0; // no need
            linkedNumbers.Add(start, 0);
            while (true)
            {
                numbers.Enqueue(numbers.Peek() + 1);
                numbers.Enqueue(numbers.Peek() + 2);
                numbers.Enqueue(numbers.Peek() * 2);

                if (!linkedNumbers.ContainsKey(numbers.Peek() + 1))
                {
                    linkedNumbers.Add(numbers.Peek() + 1, numbers.Peek());
                }
                if (!linkedNumbers.ContainsKey(numbers.Peek() + 2))
                {
                    linkedNumbers.Add(numbers.Peek() + 2, numbers.Peek());
                }
                if (!linkedNumbers.ContainsKey(numbers.Peek() * 2))
                {
                    linkedNumbers.Add(numbers.Peek() * 2, numbers.Peek());
                }
                if (linkedNumbers.ContainsKey(target))
                {
                    break;
                }
                //previousStep = currentNumb; // no need
                //currentNumb = numbers.Dequeue(); // no need
                numbers.Dequeue();
            }
            return linkedNumbers;
        }
        static void ReturnPath (Dictionary<int,int> linkedNumbers,int lastNumber)
        {
            int currentKey = lastNumber;
            while (currentKey!=0)
            {
                Console.WriteLine(currentKey);
                currentKey = linkedNumbers[currentKey];
            }
        }
        static void Main(string[] args)
        {
            int startNumb = 5;
            int endNumb = 50000;

            Dictionary<int, int> linkedNumbers = GenerateLinkedSteps(startNumb, endNumb);
            //foreach (var item in linkedNumbers)
            //{
            //    Console.WriteLine(item);
            //}
            ReturnPath(linkedNumbers, endNumb);

        }
    }
}
