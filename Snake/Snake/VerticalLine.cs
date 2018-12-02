﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Line
    {
        public VerticalLine(int yUp, int yDown, int x, char Sym)
        {
            pList = new List<Point>();
            for(int y = yUp; y<=yDown; y++)
            {
                Point p = new Point(x, y, Sym);
                pList.Add(p);
            }
        }
    }
}
