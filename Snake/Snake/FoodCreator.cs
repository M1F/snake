using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator:Random
    {
        int mapWidth;
        int mapHeight;
        char sym;

        public FoodCreator(int mapWidth, int mapHeight, char sym)
        {
            this.mapWidth = mapWidth;
            this.mapHeight = mapHeight;
            this.sym = sym;            
        }

        public Point CreateFood()
        {
            Random rand = new Random();
            int x = rand.Next(2, mapWidth-2);
            int y = rand.Next(2, mapHeight - 2);
            return new Point(x, y, sym);
        }
    }
}
