using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program6
    {
        static void Main(string[] args)
        {         
            int x1 = Int32.Parse(Console.ReadLine());
            int y1 = Int32.Parse(Console.ReadLine());
            int x2 = Int32.Parse(Console.ReadLine());
            int y2 = Int32.Parse(Console.ReadLine());
            int x3 = Int32.Parse(Console.ReadLine());
            int y3 = Int32.Parse(Console.ReadLine());

            //считываем длины сторон треугольника, который составляют 3 данные точки
            double length12 = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            double length23 = Math.Sqrt((x3 - x2) * (x3 - x2) + (y3 - y2) * (y3 - y2));
            double length31 = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));

            //по формуле Герона находим полупериметр и площадь треугольника
            double poluPerimetr = (length12 + length23 + length31)/2;
            double s = Math.Sqrt(poluPerimetr * (poluPerimetr - length12) * (poluPerimetr - length23) * (poluPerimetr - length31));

            //искомое расстояние - высота, опущенная на сторону, противоположную первой точке
            double distance = 2 * s / length23;

            Console.WriteLine(distance);

            Console.ReadKey();
        }
    }
}
