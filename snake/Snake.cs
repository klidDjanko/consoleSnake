using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake : Figure
    {
        //Конструктор для отображения змеи на экране
        public Snake(Point tail, int length, Direction direction)
        {
            //создаём коорданаты тела змеи из координат(точки) хвоста, длины и направления движения
            for(int offset = 0; offset < length; offset++)
            {
                //создаём точку из точки хвоста
                Point point = new Point(tail);
                //корректируем её на нужное смещение по нужной оси x или y
                point.Move(ref point, direction, offset);
                //вносим значение координаты в лист
                coordinats.Add(point);
            }
        }
    }
}
