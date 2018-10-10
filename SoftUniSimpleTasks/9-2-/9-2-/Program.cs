using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2_1
{
    class Program
    {
        static decimal charValue(char c, decimal money)
        {

            if (c >= 60 && c <= 90)
            {
                return (decimal)((int)c * 0.5);
            }
            if (c >= 97 && c <= 122)
            {
                return (decimal)((int)c * 0.3);
            }
            if (c=='%')
            {
                return  money * 0.5m;
            }
            if (c == '*')
            {
                return -10m;
            }
            return (decimal)((int)c);
        }

        static void Main(string[] args)
        {
            var money = decimal.Parse(Console.ReadLine());
            var command = Console.ReadLine();
            var exitCommand = "mall.Exit";
            var enterCommand = "mall.Enter";
            var moneyLeft = money;
            var realMoney = money;

            while (command!=enterCommand)
            {
                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            var counter = 0;

            while (command!=exitCommand)
            {
                int commandLength = command.Length;
                var purchase = false;

                foreach (char letter in command)
                {
                    if (moneyLeft>= charValue(letter, moneyLeft))
                    {
                        moneyLeft -=charValue(letter,moneyLeft);
                        //counter++;
                        purchase = true;
                    }      
                    
                }
                if (purchase)
                {
                    counter++;
                    realMoney = moneyLeft;
                }
                moneyLeft = realMoney;
                //counter++; // trqbva da e vytre v if
                command = Console.ReadLine();
            }

            if (counter == 0)
            {
                Console.WriteLine("No purchases. Money left: {0:F2} lv.", realMoney);
            }
            else
            {
                Console.WriteLine("{0} purchases. Money left: {1:F2} lv.", counter, realMoney);
            }
            //Console.WriteLine(moneyLeft);
        }
    }
}
