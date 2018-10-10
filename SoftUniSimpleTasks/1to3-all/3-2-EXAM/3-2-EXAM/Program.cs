using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            double costtaxid = n * 0.79 + 0.7;
            double costtaxin = n * 0.90 + 0.7;
            double costtaxi;
            if (time == "day")
            {
                costtaxi = costtaxid;
            }
            else
            {
                costtaxi = costtaxin;
            }
            double costbus = n * 0.09;
            double costtrain = n * 0.06;
            
            
                if (n<20)
                {
                    Console.WriteLine(costtaxi);
                }
                else if (n<100)
                {
                    Console.WriteLine(Math.Min(costtaxi,costbus));
                }
                else
                {
                    Console.WriteLine(Math.Min(Math.Min(costtaxi,costbus),costtrain));
                }
            
        }
    }
}
