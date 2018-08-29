using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine().ToLower();
            var nights = int.Parse(Console.ReadLine());
            var season = string.Empty;
            double stpr = 0;
            double appr = 0;
            if (month == "may"|| month=="october")
            {
                season = "first";
            }
            else if (month == "june" || month == "september")
            {
                season = "second";
            }
            else if (month == "july" || month == "august")
            {
                season = "third";
            }
            if (season == "first")
            {
                stpr = 50;
                appr = 65;
                if (nights>7 && !(nights >14))  //!!!!!!
                {
                    stpr = stpr * 0.95;
                }
                else if (nights>14)
                {
                    stpr = stpr * 0.7;
                    appr = appr * 0.9;
                }

            }
            if (season=="second")
            {
                stpr = 75.2;
                appr = 68.7;
                if  (nights > 14)
                {
                    stpr = stpr * 0.8;
                    appr = appr * 0.9;
                }

            }
            if (season == "third")
            {
                stpr = 76;
                appr = 77;
                if (nights > 14)
                {
                    appr = appr * 0.9;
                }
            }
            var totalst = nights * stpr;
            var totalap = nights * appr;
            Console.WriteLine("Apartment: {0:F2} lv.",totalap);
            Console.WriteLine("Studio: {0:F2} lv.",totalst);
        }
    }
    
}
