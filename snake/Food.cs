using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Food
    {
        //ширина, высота игрового поля, символ еды
        int width;
        int height;
        char foodChar;

        //Конструктор класса "Еда"
        public Food(int width, int height, char sym)
        {
            this.width = width;
            this.height = height;
            foodChar = sym;
        }

        //Метод создания еды
        public void MakeFood(ref List<Point> snakePosition)
        {
            //координаты еды
            int x = 1;
            int y = 1;
            //координаты головы змеи
            int xHead = snakePosition.Last().x;
            int yHead = snakePosition.Last().y;
            //координаты хвоста змеи
            int xTail = snakePosition.First().x;
            int yTail = snakePosition.First().y;

            //cгенерируем координаты размещения еды случайно исключая появление еды на самой змее
            Random random = new Random();
            //если змея движется в вертикали
            if(xHead == xTail)
            {
                x = random.Next(1, width);
                y = random.Next(1, height);
                if(yHead > yTail)
                while(yHead > y && yTail < y) y = random.Next(1, height);
                else while (yHead < y && yTail > y) y = random.Next(1, height);
            }
            //если змея движется в горизонтали
            if(yHead == yTail)
            {
                y = random.Next(1, height);
                x = random.Next(1, width);
                if (xHead > xTail)
                while (xHead > x && xTail < x) x = random.Next(1, width);
                else while (xHead < x && xTail > x) x = random.Next(1, width);
            }

            //Создаём точку и выводим еду на игровую карту
            Point foodPoint = new Point(x, y, foodChar);
            foodPoint.Draw();

        }
    }
}
