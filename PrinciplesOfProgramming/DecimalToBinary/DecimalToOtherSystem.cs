using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class DecimalToOtherSystem
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            var numeralSystem = int.Parse(Console.ReadLine());
            string newNumb = string.Empty;

            if (numeralSystem<=10)
            {
                
                do
                {
                    newNumb = (numb % numeralSystem) + newNumb;
                    numb = numb / numeralSystem;
                } while (numb!=0);
            }
            //Console.WriteLine(newNumb);
            else if (numeralSystem<=16)
            {
                do
                {
                    var remainder = numb % numeralSystem;
                    switch (remainder)
                    {
                        case 10:
                            newNumb = "A" + newNumb;
                            break;
                        case 11:
                            newNumb = "B" + newNumb;
                            break;
                        case 12:
                            newNumb = "C" + newNumb;
                            break;
                        case 13:
                            newNumb = "D" + newNumb;
                            break;
                        case 14:
                            newNumb = "E" + newNumb;
                            break;
                        case 15:
                            newNumb = "F" + newNumb;
                            break;
                        case 16:
                            newNumb = "G" + newNumb;
                            break;

                        default:
                            newNumb = remainder + newNumb;
                            break;
                    }
                    numb = numb / numeralSystem;
                } while (numb != 0);
            }
            Console.WriteLine(newNumb);
        }
    }
}
