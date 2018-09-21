using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class MagicSquares
{

    // Complete the formingMagicSquare function below.;
    // the middle cell is 5, after that in a cycle find all the magic circles

    static int formingMagicSquare(int[][] s)
    {
        int minDiff = int.MaxValue;
        int tempDiff = 0;
        int[][] magicSq = new int[3][];

        for (int i = 0; i < 3; i++)
        {
            magicSq[i] = new int[3];
        }

        magicSq[1][1] = 5;                                                //1

        for (int i = 2; i < 9; i += 2)
        {

            magicSq[0][0] = i;                                          //2
            magicSq[2][2] = 15 - 5 - i;                                        //3

            for (int j = 1; j < 10; j += 2)
            {
                if (j == 5 || j + i < 6 || j + i > 14 || 15 - j - i == i)
                {
                    continue;
                }
                magicSq[0][1] = j;                                      //4                         
                magicSq[0][2] = 15 - magicSq[0][0] - magicSq[0][1];      //5
                magicSq[1][2] = 15 - magicSq[0][2] - magicSq[2][2];      //6
                magicSq[1][0] = 15 - magicSq[1][1] - magicSq[1][2];      //7
                magicSq[2][0] = 15 - magicSq[0][0] - magicSq[1][0];      //8
                magicSq[2][1] = 15 - magicSq[2][0] - magicSq[2][2];      //9

                for (int ind1 = 0; ind1 < 3; ind1++)
                {
                    for (int ind2 = 0; ind2 < 3; ind2++)
                    {
                        tempDiff += Math.Abs(s[ind1][ind2] - magicSq[ind1][ind2]);
                        Console.Write(magicSq[ind1][ind2]+" ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                if (tempDiff < minDiff)
                {
                    minDiff = tempDiff;
                }
                tempDiff = 0;
            }
        }
        return minDiff;
    }

    static void Main(string[] args)
    {
        

        int[][] s = new int[3][];
        s[0] = new int[] { 4, 8, 2 };
        s[1] = new int[] { 4, 5, 7 };
        s[2] = new int[] { 6, 1, 6 };

        int result = formingMagicSquare(s);

        Console.WriteLine(result);

        
    }
}
