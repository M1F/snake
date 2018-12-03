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

        public void Move(int ofset, Direction direction)
        {
            if (direction == Direction.left)
            {
                x = x-ofset;
            }
            if (direction == Direction.up)
            {
                y = y-ofset;
            }
            if (direction == Direction.right)
            {
                x = x+ofset;
            }
            if (direction == Direction.down)
            {
                y = y+ofset;
            }
        }

        internal void Clear()
        {
            sym = ' ';
            Draw();
        }

        public override string ToString()
        {
            return "x = " + x + ", Y = " + y + ", Symbol = " + sym;
        }
    }
}
