using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_11
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            double OddSum = 0;
            double OddMin = double.MaxValue;
            double OddMax = double.MinValue;
            double EvenSum = 0;
            double EvenMin = double.MaxValue;
            double EvenMax = double.MinValue;

            for (int i = 1; i < n+1; i++)
            {
                double numb = double.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    EvenSum += numb;
                    if (EvenMin>numb)
                    {
                        EvenMin = numb;
                    }
                    if (EvenMax<numb)
                    {
                        EvenMax = numb;
                    }
                }
                else
                {
                    OddSum += numb;
                    if (OddMin > numb)
                    {
                        OddMin = numb;
                    }
                    if (OddMax < numb)
                    {
                        OddMax = numb;
                    }
                }
            }
            string OddSums = OddSum.ToString();
            string OddMins = OddMin.ToString();
            string OddMaxs = OddMax.ToString();
            string EvenSums = EvenSum.ToString();
            string EvenMins = EvenMin.ToString();
            string EvenMaxs = EvenMax.ToString();
            if (OddMin==double.MaxValue)
            {
                 OddMins = "No";
            }
            if (OddMax == double.MinValue)
            {
                OddMaxs = "No";
            }
            if (EvenMin == double.MaxValue)
            {
                EvenMins = "No";
            }
            if (EvenMax == double.MinValue)
            {
                EvenMaxs = "No";
            }
            Console.WriteLine("OddSum={0},",OddSums);
            Console.WriteLine("OddMin={0},",OddMins);
            Console.WriteLine("OddMax={0},",OddMaxs);
            Console.WriteLine("EvenSum={0},",EvenSums);
            Console.WriteLine("EvenMin={0},",EvenMins);
            Console.WriteLine("EvenMax={0}",EvenMaxs);
        }
    }
}
