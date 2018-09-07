using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Methods
{
    public class Methods
    {
        public static void DisplayArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0,5}",arr[i]);
            }
            Console.WriteLine();
        }

        public static void DisplayArrayRectangle(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0,5}", arr[i,j]);
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            
        }

        static void Main(string[] args)
        {
            Console.WriteLine();
            
        }
    }
}
