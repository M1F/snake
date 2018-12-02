using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(170,40);
            Console.SetBufferSize(170, 40);
            HorizontalLine up = new HorizontalLine(0,168,0,'+');
            HorizontalLine down = new HorizontalLine(0, 168, 39, '+');
            VerticalLine left = new VerticalLine(1, 39, 0, '+');
            VerticalLine right = new VerticalLine(1, 38, 169, '+');
            up.Draw();
            down.Draw();
            left.Draw();
            right.Draw();

            Point tail = new Point(5, 3, '*');
            Snake snake = new Snake(tail, 7, Direction.right);
            snake.Draw();
            Console.ReadLine();
        }
    }
}
