using System;
using System.Linq;

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

        //Метод управления движением змеи с клавиатуры
        public void SnakeControl(ConsoleKey key)
        {
            if (key == ConsoleKey.UpArrow) direction = Direction.up;
            if (key == ConsoleKey.DownArrow) direction = Direction.down;
            if (key == ConsoleKey.LeftArrow) direction = Direction.left;
            if (key == ConsoleKey.RightArrow) direction = Direction.right;
        }

        //Метод для определения столкновения
        public bool Collision()
        {
            bool isDetect = false;
            //проверим не столкнулась ли голова с телом
            //значит, что в листе есть две одинаковых точки
            Point head = coordinats.Last();
            for (int i = 0; i < coordinats.Count - 1; i++)
            {
                //столкновение головы с телом
                if (head.x == coordinats[i].x && head.y == coordinats[i].y)
                    isDetect = true;
            }

            //проверим не столкнулась ли змея с ограждением игрового поля
            if (head.x == 0 || head.y == 0 || head.x == 100 || head.y == 24) isDetect = true;

            return isDetect;
        }

        //Метод, когда змейка ест
        public bool Eat(Food food)
        {
            bool isGrow = false;

            //координаты головы
            int xHead = coordinats.Last().x;
            int yHead = coordinats.Last().y;

            //координаты хвоста
            int xTail = coordinats.First().x;
            int yTail = coordinats.First().y;

            //голова нашла еду
            if(xHead == food.x && yHead == food.y)
            {
        
                    //новое звено в росте змеи
                    Point growSnake = new Point(food.x, food.y, 'x');
                    coordinats.Add(growSnake);
 
                isGrow = true;
            }

            return isGrow;
        }
    }
}
