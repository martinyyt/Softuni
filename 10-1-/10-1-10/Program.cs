using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_10
{
    class Program
    {
        static string RepeatString(string str, int count)
        {
            string repeatString = string.Empty;
            repeatString = string.Concat(Enumerable.Repeat(str, count));
            //for (int i = 0; i < count; i++)
            //{
           //     repeatString += str;
           // }
            return repeatString;
        }

        static void Main(string[] args)
        {
            var str1 = Console.ReadLine();
            var repeat = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatString(str1, repeat));
        }
    }
}
