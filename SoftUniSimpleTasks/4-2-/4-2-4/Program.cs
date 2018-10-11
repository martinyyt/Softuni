using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal budg = decimal.Parse(Console.ReadLine());
            var type = Console.ReadLine().ToLower();
            int people = int.Parse(Console.ReadLine());
            decimal vip = 499.99M;
            decimal normal = 249.99M;
            decimal cost = 0M;
            decimal perc = 0M;
            decimal dif = 0M;
            if (people >=1 && people<=4)
            {
                perc = 0.75M;
            }
            else if (people >= 5 && people <= 9)
            {
                perc = 0.6M;
            }
            else if (people >= 10 && people <= 24)
            {
                perc = 0.5M;
            }
            else if (people >= 25 && people <= 49)
            {
                perc = 0.4M;
            }
            else
            {
                perc = 0.25M;
            }
            if (type == "normal")
            {
                cost = people * normal;
            }
            else
            {
                cost = people * vip;
            }
            dif = Math.Round( budg * (1 - perc) - cost,2);
            if (dif >=0)
            {
                Console.WriteLine("Yes! You have {0} leva left.",dif.ToString("F2"));
            }
            else
            {
                Console.WriteLine("Not enough money! You need {0} leva.",Math.Abs(dif).ToString("F2"));
            }
        }
    }
}
