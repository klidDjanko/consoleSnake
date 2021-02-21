using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
        //Поля класса для координат и отображаемого символа-точки
        public int x;
        public int y;
        public char symbol;

        //Конструктор для инициализации точки, её координат и отображаемого символа
        public Point(int userX, int userY, char userSym)
        {
            x = userX;
            y = userY;
            symbol = userSym;
        }

        //Конструктор для создания точки из другой точки
        public Point(Point point)
        {
            x = point.x;
            y = point.y;
            symbol = point.symbol;
        }

        //Метод корректировки позиции точки
        public void Move(ref Point point, Direction direction, int offset)
        {
            if(direction == Direction.up)
            {
                //уменьшаем координату y
                point.y = y - offset;
            }
            if(direction == Direction.down)
            {
                //увеличиваем координату y
                point.y = y + offset;
            }
            if(direction == Direction.left)
            {
                //уменьшаем координату x
                point.x = x - offset;
            }
            if (direction == Direction.right)
            {
                //увеличиваем координату x
                point.x= x + offset;
            }
        }

        //Метод убирающий точку с игрового поля
        public void Clear(ref Point point)
        {
            point.symbol = ' ';
            point.Draw();
        }

        //Метод вывода точки-символа на консоль
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}
