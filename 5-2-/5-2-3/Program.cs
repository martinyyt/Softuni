using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var life = int.Parse(Console.ReadLine());
            var old = 18;
            var money_need = 0.0;
            for (int i = 1800; i < life+1; i+=2)
            {
                money_need += 12000;
            }
            for (int i = 1801; i < life+1; i+=2)
            {
                money_need = money_need + 12000+(old + i - 1800)*50;
            }
            if (money>=money_need)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:F2} dollars left.",money-money_need);
            }
            else
            {
                Console.WriteLine("He will need {0:F2} dollars to survive.",money_need-money);
            }
        }
    }
}
