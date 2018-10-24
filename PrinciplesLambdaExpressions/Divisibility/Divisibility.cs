using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisibility
{
    class Divisibility
    {
        static List<int> numbers = new List<int> { 5, 6, 8, 5, 2, 21, 3, 6, 5, 4, 1, 2, 9, 0, 15, 58, 9, 6, 54, 8, 2, 4, 58, 6, 48, 8, 7, 42, 21 };
        static void Main(string[] args)
        {
            var filteredNumbers = numbers.Where(x => x % 7 == 0 || x % 3 == 0);
                      
            var evenNumbers = numbers.FindAll(i =>
            {
                Console.WriteLine("Value of i is: {0}", i);
                return (i % 2) == 0;
            });

            foreach (var number in filteredNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
