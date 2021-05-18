/************************************************************************************************
Константин Войцеховский

а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2
по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).
Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceXY
{
    class DistanceXY
    {
        static double distanceXY(double[] p1, double[] p2) {
            return Math.Sqrt(Math.Pow(p2[0] - p1[0], 2) + Math.Pow(p2[1] - p1[1], 2));
        }

        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.Unicode;
            int initialConsoleCursorSize = Console.CursorSize;
            Console.CursorSize = 100;


            Console.WriteLine("Calculator of the distance between 2 points (v.0.1)");


            Console.Write("Enter coordinates of the 1st point (separated by SPACE): ");
            String point1Input = Console.ReadLine();
            double x1 = Convert.ToDouble(point1Input.Split(' ')[0]);
            double y1 = Convert.ToDouble(point1Input.Split(' ')[1]);

            Console.Write("Enter coordinates of the 2nd point (separated by SPACE): ");
            String point2Input = Console.ReadLine();
            double x2 = Convert.ToDouble(point2Input.Split(' ')[0]);
            double y2 = Convert.ToDouble(point2Input.Split(' ')[1]);

            double[] point1 = { x1, y1 };
            double[] point2 = { x2, y2 };

            Console.WriteLine("The distance between [{0:F2}, {1:F2}] and [{2:F2}, {3:F2}] is {4:F2}",
                x1, y1, x2, y2, distanceXY(point1, point2));

            Console.CursorSize = initialConsoleCursorSize;
        }
    }
}
