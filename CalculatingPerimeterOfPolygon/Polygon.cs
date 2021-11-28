using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6
{
    public class Polygon
    {
        private List<Point> points = new List<Point>();

        public Polygon(Point p1, Point p2, Point p3, string name)
        {
            points.Add(p1);
            points.Add(p2);
            points.Add(p3);
            Name = name;
        }

        public Polygon(Point p1, Point p2, Point p3, Point p4, string name)
        {
            points.Add(p1);
            points.Add(p2);
            points.Add(p3);
            points.Add(p4);
            Name = name;
        }

        public Polygon(Point p1, Point p2, Point p3, Point p4, Point p5, string name)
        {
            points.Add(p1);
            points.Add(p2);
            points.Add(p3);
            points.Add(p4);
            points.Add(p5);
            Name = name;
        }

        public Polygon(Point[] point, string name)
        {
            foreach(Point p in point)
            {
                points.Add(p);
            }
            Name = name;
        }

        public string Name { get; private set; }

        /// <summary>
        /// рассчитывает периметр многоугольника.
        /// </summary>
        public double Perimeter()
        {
            int degree = 2;
            double p = 0;

            for (int i = 0; i < points.Count; i++)
            {
                int p2 = i + 1;
                if (p2 == points.Count)
                {
                    p2 = 0;
                }

                p += Math.Sqrt(Math.Pow(points[p2].X - points[i].X, degree)
                    + Math.Pow(points[p2].Y - points[i].Y, degree));
            }

            return Math.Round(p, 3);
        }
    }
}
