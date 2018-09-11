using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnySystemToDecimal
{
    class AnySystemToDecimal
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine().ToLower();
            int numeralSystem = int.Parse(Console.ReadLine());
            int newNum = 0;
            char[] numArray = num.ToCharArray();

            for (int i = 0, j = numArray.Length-1; i < numArray.Length && j >= 0; i++, j--)
            {
                switch (numArray[j])
                {
                    case '0':
                        newNum += 0*((int)Math.Pow(numeralSystem, i));
                        break;
                    case '1':
                        newNum += 1 * ((int)Math.Pow(numeralSystem, i));
                        break;
                    case '2':
                        newNum += 2 * ((int)Math.Pow(numeralSystem, i));
                        break;
                    case '3':
                        newNum += 3 * ((int)Math.Pow(numeralSystem, i));
                        break;
                    case '4':
                        newNum += 4 * ((int)Math.Pow(numeralSystem, i));
                        break;
                    case '5':
                        newNum += 5 * ((int)Math.Pow(numeralSystem, i));
                        break;
                    case '6':
                        newNum += 6 * ((int)Math.Pow(numeralSystem, i));
                        break;
                    case '7':
                        newNum += 7 * ((int)Math.Pow(numeralSystem, i));
                        break;
                    case '8':
                        newNum += 8 * ((int)Math.Pow(numeralSystem, i));
                        break;
                    case '9':
                        newNum += 9 * ((int)Math.Pow(numeralSystem, i));
                        break;
                    case 'a':
                        newNum += 10 * ((int)Math.Pow(numeralSystem, i));
                        break;
                    case 'b':
                        newNum += 11 * ((int)Math.Pow(numeralSystem, i));
                        break;
                    case 'c':
                        newNum += 12 * ((int)Math.Pow(numeralSystem, i));
                        break;
                    case 'd':
                        newNum += 13 * ((int)Math.Pow(numeralSystem, i));
                        break;
                    case 'e':
                        newNum += 14 * ((int)Math.Pow(numeralSystem, i));
                        break;
                    case 'f':
                        newNum += 15 * ((int)Math.Pow(numeralSystem, i));
                        break;
                    default:
                        Console.WriteLine("numeral system greater than 16");
                        break;
                }
            }

            Console.WriteLine(newNum);
        }
    }
}
