using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_Methods;

namespace MultiplyPolynoms
{
    class Program
    {
        static int[] MultiplyTwoPolinoms(int[] firstPolynom, int[] secondPolynom)
        {
            int[] result = new int[firstPolynom.Length + secondPolynom.Length-1];

            for (int i = 0; i < firstPolynom.Length; i++)
            {
                for (int j = 0; j < secondPolynom.Length; j++)
                {
                    result[i + j] += firstPolynom[i] * secondPolynom[j];
                }
            }

            return result;
        }

        static void Main(string[] args)
        {
            int[] arr1 = { -3, 1, 3 }; //index is equal to the exponent
            int[] arr2 = { -1, 1 };

            Methods.DisplayArray(MultiplyTwoPolinoms(arr1, arr2));

        }
    }
}
