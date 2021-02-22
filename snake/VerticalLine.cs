
namespace snake
{
    class VerticalLine : Figure
    {
        //Создадим конструктор для инициализации массива точек
        public VerticalLine(int yTop, int yBottom, int x, char symbol)
        {
            for (int y = yTop; y <= yBottom; y++)
            {
                Point point = new Point(x, y, symbol);
                coordinats.Add(point);
            }
        }
    }
}
