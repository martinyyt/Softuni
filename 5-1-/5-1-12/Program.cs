using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double diff = 0;
            double diffmax = 0;
            double sumold = 0;
            string check = "Yes, value=";
            for (int i = 0; i < n; i++)
            {
                double sum1 = 0;
                for (int j = i; j < i+2; j++)
                {
                    
                    var N = double.Parse(Console.ReadLine());
                    sum1 += N;
                }
                //Console.WriteLine("sum1="+sum1);//test!!
                if (i==0)
                {
                    sum = sum1;
                    sumold = sum1;
                }
                if (!(sumold==sum1))
                {
                    diff = Math.Abs(sumold - sum1);
                   // Console.WriteLine("diff="+diff);//test!!!
                    if (diff>diffmax)
                    {
                        diffmax = diff;
                    }
                }
                sumold = sum1;

            }
            if (!(diffmax==0))
            {
                check = "No, maxdiff=";
                Console.WriteLine(check+diffmax);
            }
            else
            {
                Console.WriteLine(check+sum);
            }
            //Console.WriteLine(diffmax);
        }
    }
}
