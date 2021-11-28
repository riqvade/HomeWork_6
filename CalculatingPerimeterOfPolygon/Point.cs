using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    public class Point
    {
        public Point(int x, int y, string pointName)
        {
            X = x;
            Y = y;
            PointName = pointName;
        }

        public int X { get; }
        public int Y { get; }
        public string PointName { get; }


        /// <summary>
        /// Возвращает массив точек.
        /// </summary>
        /// <param name="number">Колличество генерируемых точек.</param>
        /// <param name="minRandomСoordinateValue">Минимальное генерируемое значение точек.</param>
        /// <param name="maxRandomСoordinateValue">Максимальное генерируемое значение вектора.</param>
        public static Point[] GetArrayOfPoints(int number, int minRandomСoordinateValue = 0, int maxRandomСoordinateValue = 20)
        {
            Random random = new Random();
            Point[] points = new Point[number];
            for (int i = 0; i < number; i++)
            {
                points[i] = new Point(random.Next(minRandomСoordinateValue, maxRandomСoordinateValue),
                    random.Next(minRandomСoordinateValue, maxRandomСoordinateValue),
                    $"p{i + 1}");
            }

            return points;
        }

        public override string ToString()
        {
            return $"Координаты точки {PointName} составляют: Х - {X}, Y - {Y}";
        }
    }
}
