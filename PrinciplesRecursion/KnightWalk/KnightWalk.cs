using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightWalk
{
    class KnightWalk
    {
        static void Main(string[] args)
        {
            int[,] board = new int[8, 8];

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = -1;
                }
            }

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write("{0,4}", board[i, j]);
                }
                Console.WriteLine();
            }

        }
        static int[,] stepVariations = { { 1, 2 }, { 1, -2 }, { -1, 2 }, { -1, -2 }, { 2, 1 }, { 2, -1 }, { -2, 1 }, { -2, -1 } };
        static int counter = 0;

        static void NextStep(int[,] board, int startX, int startY)
        {
            if (counter == 64)
            {
                return;
            }
            for (int i = 0; i < 8; i++)
            {
                if (!(startX + stepVariations[i, 0] < 8 && startX + stepVariations[i, 0] > -1 &&
                    startY + stepVariations[i, 1] < 8 && startY + stepVariations[i, 1] > -1))
                {
                    continue;
                }
                counter++;
                board[startX, startY] = counter;
                NextStep(board, startX + stepVariations[i, 0], startY + stepVariations[i, 1]);

            }
        }
    }
}