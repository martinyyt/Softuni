using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace CountOccurancesPlusStuff
{
    public class CountOccurancesPlusStuff
    {
        static Dictionary<int, int> CountOccurances(List<int> numbers)
        {
            Dictionary<int, int> numbersCount = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbersCount.ContainsKey(numbers[i]))
                {
                    numbersCount[numbers[i]]++;
                }
                else
                {
                    numbersCount.Add(numbers[i], 1);
                }
            }
            return numbersCount;
        }
        static List<int> RemoveNegatives(List<int> numbers)
        {
            List<int> result = new List<int>();
            foreach (var number in numbers)
            {
                if (!(number<0))
                {
                    result.Add(number);
                }
            }
            return result;
        }
        public static void PrintList(List<int> list)
        {
            foreach (var numb in list)
            {
                Console.Write(numb+"; ");
            }
            Console.WriteLine();
        }
        static List<int> RemoveOddOccurances(List<int> numbers)
        {
            Dictionary<int, int> numberOccurances = CountOccurances(numbers);
            List<int> result = new List<int>();
            foreach (var number in numbers)
            {
                if (!(numberOccurances[number]%2==1))
                {
                    result.Add(number);
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 4, 2, 5, -8, 6, -3, 4, 5, -8, 9, -6, 3, 1, 5, 7, 82, 5, 0, 5 };
            List<int> noNegatives = RemoveNegatives(numbers);
            Dictionary<int, int> numbersCount = CountOccurances(numbers);
            
            foreach (var number in numbersCount)
            {
                Console.WriteLine(number);
            }
            PrintList(noNegatives);
            PrintList(RemoveOddOccurances(numbers));

        }
    }
}
