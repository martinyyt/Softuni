using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_12
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = Double.Parse(Console.ReadLine());
            var cur_in = Console.ReadLine();
            var cur_out = Console.ReadLine();
            var sum_lv = 0.0;
            if (cur_in == "BGN")
            {
                sum_lv = sum;
            }
            else if (cur_in == "USD")
            {
                 sum_lv = sum * 1.79549;
            }
            else if (cur_in == "EUR")
            {
                 sum_lv = sum * 1.95583;
            }
            else if (cur_in == "GBP")
            {
                 sum_lv = sum * 2.53405;
            }
            if (cur_out == "BGN")
            {
                Console.WriteLine(Math.Round( sum_lv,2));
            }
            else if (cur_out == "USD")
            {
                Console.WriteLine(Math.Round(sum_lv / 1.79549,2));  
            }
            else if (cur_out == "EUR")
            {
                Console.WriteLine(Math.Round(sum_lv / 1.95583,2));
            }
            else if (cur_out == "GBP")
            {
                Console.WriteLine(Math.Round(sum_lv / 2.53405,2));
            }
        }
    }
}
