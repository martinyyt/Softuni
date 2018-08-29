using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_12
{
    class Program
    {
        static string IntegerToBase(int number, int toBase)
        {
            string newNumber = string.Empty;
            //int position = 0;
            
                while (number!=0)
                {
                var ostatak = number % toBase;
                    //var lastDigit=number%10;
                    newNumber =string.Concat( ostatak, newNumber);
                    number = number / toBase;
                }
            return newNumber;
        }

        static void Main(string[] args)
        {
            var numb = int.Parse(Console.ReadLine());
            var bas = int.Parse(Console.ReadLine());
            Console.WriteLine(IntegerToBase(numb,bas));
        }
    }
}
