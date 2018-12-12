using System;
using System.Collections.Generic;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            HorizontalLine up = new HorizontalLine(0, mapWidth -2, 0, '+');
            HorizontalLine down = new HorizontalLine(0, mapWidth - 2, mapHeight-1, '+');
            VerticalLine left = new VerticalLine(1, mapHeight-1, 0, '+');
            VerticalLine right = new VerticalLine(1, mapHeight-2, mapWidth-1, '+');
            wallList.Add(up);
            wallList.Add(down);
            wallList.Add(left);
            wallList.Add(right);
        }

        public void Draw()
        {
            foreach(var wall in wallList)
            {
                wall.Draw();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }
    }
}