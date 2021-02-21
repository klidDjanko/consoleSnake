using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {

            //Создадим и выведем пару точек
            Point p1 = new Point(2,5,'#');
            p1.Draw();

            Point p2 = new Point(5,10,'+');
            p2.Draw();

            Console.ReadKey();
        }
    }
}
