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

            Point2D startPoint = new Point2D(0, 0, 1);
            FillMatrix(board, startPoint);

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write("{0,4}", board[i, j]);
                }
                Console.WriteLine();
            }

        }

        static Point2D[] stepVariations = { new Point2D ( 1, 2, 1 ), new Point2D ( 1, -2, 1 ),
            new Point2D ( -1, 2, 1), new Point2D ( -1, -2, 1 ),
            new Point2D ( 2, 1, 1 ), new Point2D ( 2, -1, 1 ),
            new Point2D ( -2, 1, 1 ), new Point2D ( -2, -1, 1 ) };

        static bool HaveNextCell(int[,] board, Point2D currentPoint)
        {
            bool result = false;
            foreach (var step in stepVariations)
            {
                Point2D nextPoint = new Point2D(step.X + currentPoint.X, step.Y + currentPoint.Y, currentPoint.Value + step.Value);
                if (!(nextPoint.X < 0 || nextPoint.X > 7 || nextPoint.Y < 0 || nextPoint.Y > 7 || nextPoint.Value > 64))
                {
                    if (board[nextPoint.X, nextPoint.Y] == -1)
                    {
                        result = true;
                    }
                }
            }
            return result;
        }

        static void FillMatrix(int[,] board, Point2D startPoint)
        {
            Point2D currentPoint = new Point2D(startPoint.X, startPoint.Y, startPoint.Value);
            Point2D previousPoint = new Point2D(currentPoint.X, currentPoint.Y, currentPoint.Value - 1);//???
            Stack<Point2D> stepsStack = new Stack<Point2D>();
            stepsStack.Push(currentPoint);
            //board[currentPoint.X, currentPoint.Y] = currentPoint.Value;

            //foreach (var step in stepVariations)
            //{
            //    Point2D nextPoint = new Point2D(step.X + currentPoint.X, step.Y + currentPoint.Y, currentPoint.Value + step.Value);
            //    if (!(nextPoint.X < 0 || nextPoint.X > 7 || nextPoint.Y < 0 || nextPoint.Y > 7 || nextPoint.Value > 64))
            //    {
            //        stepsStack.Push(nextPoint);
            //    }
            //}
            
            while (currentPoint.Value <= 64 && stepsStack.Count > 0)
            {
                
                currentPoint = stepsStack.Pop();
                if (!HaveNextCell(board, currentPoint) && currentPoint.Value != 64)
                {
                    board[currentPoint.X, currentPoint.Y] = -1;                    
                    continue;
                }
                else if (currentPoint.Value == 64)
                {
                    board[currentPoint.X, currentPoint.Y] = currentPoint.Value;
                    break;
                }
                if (board[currentPoint.X, currentPoint.Y] == -1)
                {
                    board[currentPoint.X, currentPoint.Y] = currentPoint.Value;
                    foreach (var step in stepVariations)
                    {
                        Point2D nextPoint = new Point2D(step.X + currentPoint.X, step.Y + currentPoint.Y, currentPoint.Value + step.Value);
                        if (nextPoint.X > -1 && nextPoint.X < 8 && nextPoint.Y > -1 && nextPoint.Y < 8)
                        {
                            stepsStack.Push(nextPoint);
                        }
                    }
                }
            }
        }
    }
}