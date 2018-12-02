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
            Point p1 = new Point(1,3,'*');
            p1.Draw();
            Point p2 = new Point(2, 4, '#');
            p2.Draw();

            List<Point> digits = new List<Point>();
            digits.Add(p1);
            digits.Add(p2);
            foreach (Point i in digits)
                Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
