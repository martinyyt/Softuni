using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortByOccuranceThenByValue
{
    class SortByOccuranceThenByValue
    {
        static SortedDictionary<int, int> CustomSort(List<int> numbers)
        {
            SortedDictionary<int, int> numberOccurances = new SortedDictionary<int, int>();
            foreach (var number in numbers)
            {
                if (numberOccurances.TryGetValue(number, out int value))
                {
                    numberOccurances[number] = value + 1;
                }
                else
                {
                    numberOccurances.Add(number, 1);
                }

            }
            return numberOccurances;
        }
        static List<int> FinalSort(SortedDictionary<int, int> numbersByOccurance)
        {
            var sortedNumbersDict = numbersByOccurance.OrderBy(x => x.Value);
            var sortedNumbers = new List<int>();
            foreach (var pair in sortedNumbersDict)
            {
                for (int i = 0; i < pair.Value; i++)
                {
                    sortedNumbers.Add(pair.Key);
                }
            }
            return sortedNumbers;
        }
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 2, 5, 6, 8, 5, 8, 6, 4, 8, 5, 6, 8, 5, 2, 4, 5, 2, 24, 86, 7 };
            //var sl = numbers.OrderBy(x => numbers.Count(p => p == x)).ThenBy(c => c);
            //foreach (var item in sl)
            //{
            //    Console.WriteLine(item);
            //} // short solution here!!! complex lambda!
            SortedDictionary<int, int> numbersByOccurance = CustomSort(numbers);
            var sortedNumbers = FinalSort(numbersByOccurance);
            
            

            foreach (var item in numbersByOccurance)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            

            foreach (var item in sortedNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
