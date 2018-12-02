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

            HorizontalLine l1 = new HorizontalLine(3,10,2,'*');
            VerticalLine l2 = new VerticalLine(3, 8, 5, '*');
            l1.Draw();
            l2.Draw();

            Console.ReadLine();
        }
    }
}
