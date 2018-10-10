using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_13
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter even number: ");
                    var n = int.Parse(Console.ReadLine());
                    if (n % 2 != 0)
                    {
                        Console.WriteLine("The number is not even.");
                        Console.Write("Enter even number: ");
                        n = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Even number entered: " + n);
                        break;
                    }
                }
                catch 
                {

                    Console.WriteLine("Invalid number."); ;
                }
            }
        }
    }
}
