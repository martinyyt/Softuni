using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateArrayList
{
    class CreateArrayList
    {
        static void CreateList(List<uint> numbers)
        {
            string line = Console.ReadLine();
            while (line != "")
            {
                if (uint.TryParse(line, out uint number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("not uint, enter new number");
                }
                line = Console.ReadLine();
            }
        }
        static double Avg(List<uint> numbers)
        {
            double avg = (double)Sum(numbers)/numbers.Count;
            return avg;
        }
        static ulong Sum(List<uint> numbers)
        {
            ulong sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            List<uint> numbers = new List<uint>();
            CreateList(numbers);
            Console.WriteLine("Sum is: {0}",Sum(numbers));
            Console.WriteLine();
            Console.WriteLine("Avg is: {0}",Avg(numbers));
            
        }
    }
}
