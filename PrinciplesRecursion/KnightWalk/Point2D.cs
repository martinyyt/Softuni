using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightWalk
{
    class Point2D
    {
        int x;
        int y;
        int value = 0;

        public Point2D(int x, int y, int value)
        {
            X = x;
            Y = y;
            Value = value;
        }

        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
            Value = 0;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Value { get => value; set => this.value = value; }
    }
}
