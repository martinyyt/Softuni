using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_14
{
    class Program
    {
        static void Letterize(int number)
        {
            var symbol = string.Empty;
            var firstWord = string.Empty;
            var secondWord = string.Empty;
            var thirdWord = string.Empty;
            var result = string.Empty;
            var firsNum = 0;
            var secondNum = 0;
            var thirdNum = 0; 
                if (number<0)
                {
                    symbol = "minus ";
                }
            number = Math.Abs(number);
            thirdNum = number % 10;
            number /= 10;
            secondNum = number % 10;
            number /= 10;
            firsNum = number % 10;
            switch (firsNum)
            {
                case 1:
                    firstWord = "one-hundred";
                    break;
                case 2:
                    firstWord = "two-hundred";
                    break;
                case 3:
                    firstWord = "three-hundred";
                    break;
                case 4:
                    firstWord = "four-hundred";
                    break;
                case 5:
                    firstWord = "five-hundred";
                    break;
                case 6:
                    firstWord = "six-hundred";
                    break;
                case 7:
                    firstWord = "seven-hundred";
                    break;
                case 8:
                    firstWord = "eight-hundred";
                    break;
                case 9:
                    firstWord = "nine-hundred";
                    break;
            }
            if (secondNum==0&&thirdNum==0)
            {
               // result = firstWord;
            }
            else if(secondNum==0&&thirdNum!=0)
            {
                switch (thirdNum)
                {
                    case 1:
                        secondWord = " and one";
                        break;
                    case 2:
                        secondWord = " and two";
                        break;
                    case 3:
                        secondWord = " and three";
                        break;
                    case 4:
                        secondWord = " and four";
                        break;
                    case 5:
                        secondWord = " and five";
                        break;
                    case 6:
                        secondWord = " and six";
                        break;
                    case 7:
                        secondWord = " and seven";
                        break;
                    case 8:
                        secondWord = " and eight";
                        break;
                    case 9:
                        secondWord = " and nine";
                        break;
                }
            }
            else if (secondNum==1)
            {
                switch (thirdNum)
                {
                    case 0:
                        secondWord = " and ten";
                        break;
                    case 1:
                        secondWord = " and eleven";
                        break;
                    case 2:
                        secondWord = " and twelve";
                        break;
                    case 3:
                        secondWord = " and thirteen";
                        break;
                    case 4:
                        secondWord = " and fourteen";
                        break;
                    case 5:
                        secondWord = " and fifteen";
                        break;
                    case 6:
                        secondWord = " and sixteen";
                        break;
                    case 7:
                        secondWord = " and seventeen";
                        break;
                    case 8:
                        secondWord = " and eighteen";
                        break;
                    case 9:
                        secondWord = " and nineteen";
                        break;
                }
            }
            else
            {
                switch (secondNum)
                {
                    case 2:
                        secondWord = " and twenty";
                        break;
                    case 3:
                        secondWord = " and thirty";
                        break;
                    case 4:
                        secondWord = " and fourty";
                        break;
                    case 5:
                        secondWord = " and fifty";
                        break;
                    case 6:
                        secondWord = " and sixty";
                        break;
                    case 7:
                        secondWord = " and seventy";
                        break;
                    case 8:
                        secondWord = " and eighty";
                        break;
                    case 9:
                        secondWord = " and ninety";
                        break;
                }
                switch (thirdNum)
                {
                    case 1:
                        thirdWord = " one";
                        break;
                    case 2:
                        thirdWord = " two";
                        break;
                    case 3:
                        thirdWord = " three";
                        break;
                    case 4:
                        thirdWord = " four";
                        break;
                    case 5:
                        thirdWord = " five";
                        break;
                    case 6:
                        thirdWord = " six";
                        break;
                    case 7:
                        thirdWord = " seven";
                        break;
                    case 8:
                        thirdWord = " eight";
                        break;
                    case 9:
                        thirdWord = " nine";
                        break;
                }
            }
            result = symbol+firstWord + secondWord + thirdWord;
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            if (number < -999)
            {
                Console.WriteLine("too small");
            }
            else if (number > 999)
            {
                Console.WriteLine("too large");
            }
            else if (number<-100 || number>100)
            {
                Letterize(number);
            }
            else
            {
               Console.WriteLine();
            }
        }
    }
}
