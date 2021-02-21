using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

            //Создадим и выведем пару точек
            Point p1 = new Point();
            p1.x = 2;
            p1.y = 5;
            p1.symbol = '*';

            p1.Draw();

            Point p2 = new Point();
            p2.x = 5;
            p2.y = 10;
            p2.symbol = '+';

            p2.Draw();

            Console.ReadKey();
        }
    }
}
