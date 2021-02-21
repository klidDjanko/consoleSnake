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

        //Метод вывода точки-символа на консоль
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}
