using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(170,40);
            Console.SetBufferSize(170, 40);
            Walls walls = new Walls(170,40);
            walls.Draw();

            Point tail = new Point(5, 3, '*');
            Snake snake = new Snake(tail, 7, Direction.right);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(170, 40, '#');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }               
            }
        }
    }
}
