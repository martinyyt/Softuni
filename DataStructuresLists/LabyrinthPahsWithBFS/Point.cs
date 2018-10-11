using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabyrinthPahsWithBFS
{
    class Point
    {
        private int x;
        private int y;
        private int step;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Step { get => step; set => step = value; }

        public Point(int x, int y,int step)
        {
            this.X = x;
            this.Y = y;
            this.Step = step;
        }
    }
}
