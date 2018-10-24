using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderByThenByExample
{
    class OrderByThenByExample
    {
        static List<int> numbers = new List<int> { 5, 6, 8, 5, 2, 3, 6, 5, 4, 1, 2, 58, 9, 6, 54, 8, 2, 4, 58, 6, 48, 8 };
        static void Main(string[] args)
        {
            var sortedNumbers = numbers.OrderBy(x=>numbers.Count(y=>y==x)).ThenBy(c => c);
            
            foreach (var number in sortedNumbers)
            {
                Console.WriteLine(number);
            }                
        }
    }
}
