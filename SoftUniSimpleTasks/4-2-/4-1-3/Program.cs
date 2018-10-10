using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var n1 = decimal.Parse(Console.ReadLine());
            var n2 = decimal.Parse(Console.ReadLine());
            string oper = Console.ReadLine();
            decimal result = 0;
            decimal evcheck = 0;
            string even = string.Empty;
            string plus = "+";
            string min = "-";
            string mult = "*";
            string div = "/";
            string mod = "%";
            if ((oper == div || oper == mod) && n2 == 0)
            {
                Console.WriteLine("Cannot divide {0} by zero",n1);
            }
            else if (oper == plus || oper == min || oper == mult)
            {
                if (oper == plus)
                {
                    result = n1 + n2;
                }
                else if (oper == min)
                {
                    result = n1 - n2;
                }
                else if (oper == mult)
                {
                    result = n1 * n2;
                }
                evcheck = result % 2;
                if (evcheck == 0)
                {
                    even = "even";
                }
                else
                {
                    even = "odd";
                }
                Console.WriteLine("{0} {1} {2} = {3} - {4}",n1,oper,n2,result,even);
            }
            else if (oper == div)
            {
                result = Math.Round( n1/n2,2);
                //Console.WriteLine(result);
                Console.WriteLine("{0} / {1} = {2}",n1,n2,result.ToString("F2"));
            }
            else if (oper == mod)
            {
                result = n1 % n2;
                Console.WriteLine("{0} % {1} = {2}",n1,n2,result);
            }
        }
    }
}
