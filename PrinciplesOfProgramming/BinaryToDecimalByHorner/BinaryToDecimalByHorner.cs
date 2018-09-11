using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimalByHorner
{
    class BinaryToDecimalByHorner
    {
        static void Main(string[] args)
        {
            long binaryNum = long.Parse( Console.ReadLine()); // better to be string for the range!!!
            long decimalNum = 0;
            long[] binaryArray = new long[binaryNum.ToString().Length];

            for (int i = binaryArray.Length-1; i >=0; i--)
            {
                binaryArray[i] = binaryNum % 10;
                binaryNum /= 10;
            }

            for (int i = 0; i < binaryArray.Length; i++)
            {
                decimalNum = decimalNum * 2 + binaryArray[i];
                //Console.WriteLine(decimalNum);
                //Console.WriteLine(binaryArray[i]);
            }

            Console.WriteLine((int)decimalNum);
        }
    }
}
