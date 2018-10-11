using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthPahsWithBFS
{
    class LabyrinthPathBFS
    {
        static void FindAllPaths(string[,] laby)
        {
            Point startPoss = new Point(0, 0, 0);
            
            for (int i = 0; i < laby.GetLength(0); i++)
            {
                for (int j = 0; j < laby.GetLength(1); j++)
                {
                    if (laby[i, j] == "*")
                    {
                        startPoss.X = i;
                        startPoss.Y = j;
                    }
                }
            }
            Queue<Point> steps = new Queue<Point>();            
            if ((startPoss.X > 0) && (laby[startPoss.X - 1, startPoss.Y] == "0"))
            {
                steps.Enqueue(new Point(startPoss.X - 1, startPoss.Y, startPoss.Step+1));
            }
            if ((startPoss.Y > 0) && (laby[startPoss.X, startPoss.Y - 1] == "0"))
            {
                steps.Enqueue(new Point(startPoss.X, startPoss.Y - 1, startPoss.Step + 1));
            }
            if ((startPoss.X < laby.GetLength(0)) && (laby[startPoss.X + 1, startPoss.Y] == "0"))
            {
                steps.Enqueue(new Point(startPoss.X + 1, startPoss.Y, startPoss.Step + 1));
            }
            if ((startPoss.Y < laby.GetLength(1)) && (laby[startPoss.X, startPoss.Y + 1] == "0"))
            {
                steps.Enqueue(new Point(startPoss.X, startPoss.Y + 1, startPoss.Step + 1));
            }            
            while (steps.Count > 0)
            {
                startPoss = steps.Dequeue();
                laby[startPoss.X, startPoss.Y] = startPoss.Step.ToString();
                if ((startPoss.X > 0) && (laby[startPoss.X - 1, startPoss.Y] == "0"))
                {
                    steps.Enqueue(new Point(startPoss.X - 1, startPoss.Y,startPoss.Step+1));
                }
                if ((startPoss.Y > 0) && (laby[startPoss.X, startPoss.Y - 1] == "0"))
                {
                    steps.Enqueue(new Point(startPoss.X, startPoss.Y - 1, startPoss.Step + 1));
                }
                if ((startPoss.X < laby.GetLength(0) - 1) && (laby[startPoss.X + 1, startPoss.Y] == "0"))
                {
                    steps.Enqueue(new Point(startPoss.X + 1, startPoss.Y, startPoss.Step + 1));
                }
                if ((startPoss.Y < laby.GetLength(1) - 1) && (laby[startPoss.X, startPoss.Y + 1] == "0"))
                {
                    steps.Enqueue(new Point(startPoss.X, startPoss.Y + 1, startPoss.Step + 1));
                }                
            }
        }
        static void Main(string[] args)
        {
            string[,] labyrinth = new string[,]
            {
                { "0", "0", "0", "x", "0", "x" },
                { "0", "x", "0", "x", "0", "x" },
                { "0", "*", "x", "0", "x", "0" },
                { "0", "x", "0", "0", "0", "0" },
                { "0", "0", "0", "x", "0", "0" },
                { "0", "x", "0", "x", "0", "x" },
                { "0", "0", "0", "x", "0", "0" }
            };

            FindAllPaths(labyrinth);
            
            for (int i = 0; i < labyrinth.GetLength(0); i++)
            {
                for (int j = 0; j < labyrinth.GetLength(1); j++)
                {
                    if (labyrinth[i,j]=="0")
                    {
                        labyrinth[i, j] = "U";
                    }
                    Console.Write("{0,4}",labyrinth[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
