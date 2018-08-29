using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var years = int.Parse(Console.ReadLine());
            var wash_pr = double.Parse(Console.ReadLine());
            var toys_pr = int.Parse(Console.ReadLine());
            var toys_count = 0;
            var money_gift = 10.0;
            var total_money_gift = 0.0;
            for (int i = 1; i < years+1; i+=2)
            {
                // Console.WriteLine(i);
                toys_count++;
            }
            for (int i = 2; i < years+1; i+=2)
            {
                total_money_gift =total_money_gift+ money_gift-1;
                money_gift += 10;
               // Console.WriteLine(total_money_gift);
            }
            total_money_gift = total_money_gift + toys_count * toys_pr;
            if (total_money_gift>=wash_pr)
            {
                Console.WriteLine("Yes! {0:F2}",total_money_gift-wash_pr);
            }
            else
            {
                Console.WriteLine("No! {0:F2}",wash_pr-total_money_gift);
            }
        }
    }
}
