using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_Methods;

namespace SpiralNM
{
    class SpiralNM
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine()); // rows of matrix
            var m = int.Parse(Console.ReadLine()); // columns of matrix
            var startNumb = int.Parse(Console.ReadLine());
            var colEnd = m - 1;
            var rowEnd = n - 1;
            var colStart = 0;
            var rowStart = 0;
            var numb = startNumb;
            int[,] spiral = new int[n, m];

            while (colStart<=colEnd&&rowStart<=rowEnd)
            {
                for (int right = colStart; right <= colEnd; right++)
                {
                    spiral[rowStart, right] = numb++;                    
                }
                if (numb >= n * m + startNumb)
                {
                    break;
                }
                rowStart++;

                for (int down = rowStart; down <= rowEnd; down++)
                {
                    spiral[down, colEnd] = numb++;                    
                }
                if (numb >= n * m + startNumb)
                {
                    break;
                }
                colEnd--;

                for (int left = colEnd; left >=colStart; left--)
                {
                    spiral[rowEnd, left] = numb++;                    
                }
                if (numb >= n * m + startNumb)
                {
                    break;
                }
                rowEnd--;

                for (int up = rowEnd; up >= rowStart; up--)
                {
                    spiral[up,colStart]= numb++;                    
                }

                if (numb >= n * m + startNumb)
                {
                    break;
                }
                colStart++;

                //break;
            }

            Methods.DisplayArrayRectangle(spiral);
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        Console.Write(string.Format("{0} ", spiral[i, j]));
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}
        }        
    }
}
