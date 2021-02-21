using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Snake : Figure
    {
        Direction direction;

        //Конструктор для отображения змеи на экране
        public Snake(Point tail, int length, Direction direction)
        {
            this.direction = direction;

            //создаём коорданаты тела змеи из координат(точки) хвоста, длины и направления движения
            for (int offset = 0; offset < length; offset++)
            {
                //создаём точку из точки хвоста
                Point point = new Point(tail);
                //корректируем её на нужное смещение по нужной оси x или y
                point.Move(ref point, direction, offset);
                //вносим значение координаты в лист
                coordinats.Add(point);
            }
        }

        //Метод движения змеи
        public void Move()
        {
            //получили точку хвоста
            Point tail = coordinats.First();
            //удаляем её из листа
            coordinats.RemoveAt(0);
            //получаем координату сдвига головы
            Point head = new Point(coordinats.Last());
            head.Move(ref head, direction, 1);
            //добавляем её в лист
            coordinats.Add(head);
            //стираем старую точку хвоста
            tail.Clear(ref tail);
            //рисуем точку головы
            head.Draw();
        }
    }
}
