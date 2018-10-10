using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n-i-1; j++)
                {
                    Console.Write(" "); // паузите до първата звезда
                }
                for (int z = 0; z <=i-1 ; z++)
                {
                    Console.Write("* "); // това ще печата "* " i на брой пъти
                }
                Console.Write("*");
                for (int x = 0; x < n - i-1; x++)
                {
                    Console.Write(" "); // паузите след последната звезда
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                    Console.Write(" "); // паузите до първата звезда
                }
                for (int z = 0; z < n-i-2 ; z++)
                {
                    Console.Write("* "); // това ще печата "* " i на брой пъти
                }
                Console.Write("*");
                for (int x = 0; x < i+1; x++)
                {
                    Console.Write(" "); // паузите след последната звезда
                }
                Console.WriteLine();
            }
        }
    }
}
