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
            Point p1 = new Point(2,5,'#');
            p1.Draw();

            Point p2 = new Point(5,10,'+');
            p2.Draw();

            //Попробуем нарисовать горизонтальную линию
            HorizontalLine horizontalLine = new HorizontalLine(10, 13, 8, '*');
            horizontalLine.Draw();

            //Попробуем нарисовать вертикальную линию
            VerticalLine verticalLine = new VerticalLine(8, 18, 10, '*');
            verticalLine.Draw();

            //Попробуем создать змею
            //точка её хвоста
            Point tail = new Point(2, 2, 'x');
            //змея длиной 15, ползёт вправо
            Snake snake = new Snake(tail, 15, Direction.right);
            snake.Draw();

            Console.ReadKey();
        }
    }
}
