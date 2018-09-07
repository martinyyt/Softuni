using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_Methods;

namespace DiagonalMatrix
{
    class DiagonalMatrix
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[,] diagonal = new int[n, n];
            var counter = 1;

            for (int row = n-1; row >= 0; row--)
            {
                var startRow = row;
                var startCol = 0;

                while (startRow<=n-1&&startCol<=n-1)
                {
                    diagonal[startRow, startCol] = counter++;
                    startRow++;
                    startCol++;
                }
            }

            for (int col = 1; col < n; col++)
            {
                var startRow = 0;
                var startCol = col;

                while (startRow<=n-1&&startCol<=n-1)
                {
                    diagonal[startRow, startCol] = counter++;
                    startRow++;
                    startCol++;
                }
            }

            Methods.DisplayArrayRectangle(diagonal);
        }
    }
}
