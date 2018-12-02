using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Move(int i, Direction direction)
        {
            if (direction == Direction.left)
            {
                x = x-i;
            }
            if (direction == Direction.up)
            {
                y = y-i;
            }
            if (direction == Direction.right)
            {
                x = x+i;
            }
            else
            {
                y = y+i;
            }
        }

        public override string ToString()
        {
            return "x = " + x + ", Y = " + y + ", Symbol = " + sym;
        }
    }
}
