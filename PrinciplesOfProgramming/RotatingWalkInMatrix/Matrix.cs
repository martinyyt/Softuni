using System;

namespace RotatingWalkInMatrix
{
    class Matrix
    {
        static void Change(ref int dx, ref int dy)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int cd = 0;
            for (int count = 0; count < 8; count++)
                if (dirX[count] == dx && dirY[count] == dy)
                {
                    cd = count;
                    break;
                }
            if (cd == 7)
            {
                dx = dirX[0];
                dy = dirY[0];
                return;
            }
            dx = dirX[cd + 1];
            dy = dirY[cd + 1];
        }
        static bool CanFindReachableCell(int[,] arr, int x, int y)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            for (int i = 0; i < dirX.Length; i++)
            {
                if (x + dirX[i] >= arr.GetLength(0) || x + dirX[i] < 0)
                {
                    dirX[i] = 0;
                }
                if (y + dirY[i] >= arr.GetLength(0) || y + dirY[i] < 0)
                {
                    dirY[i] = 0;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                if (arr[x + dirX[i], y + dirY[i]] == 0)
                {
                    return true;
                }
            }
            return false;
        }

        static void FindCell(int[,] arr, out int x, out int y)
        {
            x = 0;
            y = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        x = i;
                        y = j;
                        return;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int matrixLength = 3;
            int[,] matrix = new int[matrixLength, matrixLength];
            int stepCounter = 1, cellX = 0, cellY = 0, dx = 1, dy = 1;
            FillMatrix(matrix, ref stepCounter, ref cellX, ref cellY, ref dx, ref dy);

            FindCell(matrix, out cellX, out cellY);
            // taka go napravih, zashtoto funkciqta ne mi davashe da ne si definiram out parametrite
            dx = 1;
            dy = 1;
            FillMatrix(matrix, ref stepCounter, ref cellX, ref cellY, ref dx, ref dy);

            for (int i = 0; i < matrixLength; i++)
            {
                for (int j = 0; j < matrixLength; j++)
                {
                    Console.Write("{0,3}", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        private static void FillMatrix(int[,] matrix, ref int stepCounter, ref int cellX, ref int cellY, ref int dx, ref int dy)
        {
            while (CanFindReachableCell(matrix, cellX, cellY))
            {
                matrix[cellX, cellY] = stepCounter;

                while ((cellX + dx >= matrix.GetLength(0) || cellX + dx < 0 || cellY + dy >= matrix.GetLength(1) || cellY + dy < 0 || matrix[cellX + dx, cellY + dy] != 0))
                {
                    Change(ref dx, ref dy);
                }
                cellX += dx;
                cellY += dy;
                stepCounter++;
            }
        }
    }
}
