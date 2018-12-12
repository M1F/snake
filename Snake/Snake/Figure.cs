﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    abstract class Figure
    {
        protected List<Point> pList;
        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var p in pList)
            {
                if (figure.IsHit(p))
                {
                    return true;
                }
            }
            return false;
        }

        internal bool IsHit(Point point)
        {
            foreach (var p in pList)
            {
                if (p.isHit(point))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
