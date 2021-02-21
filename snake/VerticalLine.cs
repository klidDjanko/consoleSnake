using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VerticalLine
    {
        //Создадим лист для хранения точек координат линии
        List<Point> coordinats = new List<Point>();

        //Создадим конструктор для инициализации массива точек
        public VerticalLine(int yTop, int yBottom, int x, char symbol)
        {
            for (int y = yTop; y <= yBottom; y++)
            {
                Point point = new Point(x, y, symbol);
                coordinats.Add(point);
            }
        }

        //Метод вывода вертикальной линии на экран
        public void Draw()
        {
            foreach(Point point in coordinats)
            {
                point.Draw();
            }
        }
    }
}
