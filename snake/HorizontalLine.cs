using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class HorizontalLine : Figure
    {
        //Конструктор для создания горизонтальной линии
        public HorizontalLine(int xLeft, int xRight, int y, char symbol)
        {
            for (int x = xLeft; x <= xRight; x++)
            {
                //Создаём точку с координатами и заданным символом
                Point point = new Point(x, y, symbol);
                //Помещаем в лист точек
                coordinats.Add(point);
            }
        }
    }
}
