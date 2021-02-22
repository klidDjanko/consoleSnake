using System;
using System.Threading;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Установим размер окна консоли
            Console.SetWindowSize(105, 30);

            //Ограждение игрового поля
            HorizontalLine horizontalLine = new HorizontalLine(0, 100, 0, '*');
            horizontalLine.Draw();

            HorizontalLine horizontalLine2 = new HorizontalLine(0, 100, 24, '*');
            horizontalLine2.Draw();


            VerticalLine verticalLine = new VerticalLine(0, 24, 0, '*');
            verticalLine.Draw();

            VerticalLine verticalLine2 = new VerticalLine(0, 24, 100, '*');
            verticalLine2.Draw();

            //Cоздаём змею
            //точка её хвоста
            Point tail = new Point(2, 2, 'x');
            //змея длиной 3, ползёт вправо
            Snake snake = new Snake(tail, 10, Direction.right);
            snake.Draw();

            Food food = new Food(100, 24, 'o');
            food.MakeFood(ref snake.coordinats);

            //движение и управление змейкой
            while (true)
            {
                //Проверяем не закончилась ли игра если змея столкнулась с самой собой или оградой поля
                if (snake.Collision())
                {
                    break;
                }

                //Проверяем съела ли змея фрукт, если да генерим новый
                if (snake.Eat(food))
                {
                    food.MakeFood(ref snake.coordinats);
                    snake.Draw();
                }

                //Смотрим нажатия клавиш пользователем
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    //Вызываем метод управления направлением змеи из класса Snake
                    snake.SnakeControl(key.Key);
                }
                //Движение змеи
                snake.Move();
                Thread.Sleep(300);
            }
        }
    }
}
