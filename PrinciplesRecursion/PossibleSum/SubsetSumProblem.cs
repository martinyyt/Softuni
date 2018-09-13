using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PossibleSum
{
    class SubsetSumProblem
    {
        static bool SubsetSum(int[] set, int n, int sum)
        {            
            bool[,] subset = new bool[sum + 1, n + 1];
                      
            for (int i = 0; i <= n; i++)
                subset[0, i] = true;

            for (int i = 1; i <= sum; i++)
                subset[i, 0] = false;

            for (int i = 1; i <= sum; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    subset[i, j] = subset[i, j - 1];
                    if (i >= set[j - 1])
                        subset[i, j] = subset[i, j] ||
                                       subset[i - set[j - 1], j - 1];
                    
                }
            }

            for (int i = 0; i <= sum; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    Console.Write(subset[i,j]+"; ");
                }
                Console.WriteLine();
            }

            return subset[sum, n];
        }
 
        public static void Main()
        {
            
            int[] set = { 3, 34, 4, 12, 5, 1 };
            int sum = 14;
            int n = set.Length;
            if (SubsetSum(set, n, sum) == true)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
