using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintReversed
{
    class PrintReversed
    {
        static void CreateStack(Stack<int> numbers)
        {
            string line = Console.ReadLine();
            while (line!="end")
            {
                if (int.TryParse(line,out int number))
                {
                    numbers.Push(number);
                }
                else
                {
                    Console.WriteLine("enter new number");
                }
                line = Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            CreateStack(numbers);
            while (numbers.Count!=0)
            {
                Console.WriteLine(numbers.Pop());
            }
        }
    }
}
