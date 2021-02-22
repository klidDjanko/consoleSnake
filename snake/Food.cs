using System;
using System.Collections.Generic;

namespace snake
{
    class Food : Point
    {
        //ширина, высота игрового поля, символ еды
        int width;
        int height;
        char foodChar;

        //Конструктор класса "Еда"
        public Food(int width, int height, char sym) : base(width, height, sym)
        {
            this.width = width;
            this.height = height;
            foodChar = sym;
        }

        //Метод создания еды
        public void MakeFood(ref List<Point> snakePosition)
        {
            //cгенерируем координаты размещения еды случайно исключая появление еды на самой змее
            Random random = new Random();

            x = random.Next(1, width);
            y = random.Next(1, height);

            foreach (Point point in snakePosition)
            {
                while (point.x == x && point.y == y)
                {
                    x = random.Next(1, width);
                    y = random.Next(1, height);
                }
            }

            //Создаём точку и выводим еду на игровую карту
            Point foodPoint = new Point(x, y, foodChar);
            foodPoint.Draw();

        }
    }
}
