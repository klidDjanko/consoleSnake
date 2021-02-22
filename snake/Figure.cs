using System.Collections.Generic;

namespace snake
{
    class Figure
    {
        //Создадим лист для хранения точек координат
        public List<Point> coordinats = new List<Point>();

        //Метод вывода на экран
        public void Draw()
        {
            foreach (Point point in coordinats)
            {
                point.Draw();
            }
        }
    }
}
