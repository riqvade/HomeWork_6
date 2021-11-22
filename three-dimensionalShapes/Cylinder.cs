using HomeWork_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace three_dimensionalShapes
{
    internal class Cylinder : Shape
    {
        public Cylinder(double R, double H, string name = "Цилиндр")
        {
            foreach (string existName in ExistNames)
            {
                if (existName.Equals(name))
                {
                    Console.WriteLine($"Фигура с именем {name} уже существует, выберите другое нименование фигуры!");
                    Console.WriteLine();
                    return;
                }
            }

            this.R = R;
            this.H = H;
            if (name != "Цилиндр")
            {
                Name = name;
            }
            else
            {
                CylinderNumber++;
                Name = $"{name} {CylinderNumber}";
            }
            ExistNames.Add(Name);
        }

        private static int CylinderNumber { get; set; } = 0;

        /// <summary>
        /// Радиус основания цилиндра.
        /// </summary>
        private double R { get; }

        /// <summary>
        /// Высота цилиндра.
        /// </summary>
        private double H { get; }

        /// <summary>
        /// Возвращает объем целиндра.
        /// </summary>
        public override double Volume()
        {
            return Math.PI * Math.Pow(R, 2) * H;
        }

        /// <summary>
        /// Генерирует целиндр с произвольными размерами.
        /// </summary>
        public static Cylinder GetRandomCylinder(int minRandomValue = 1, int maxRandomValue = 20, string name = "Цилиндр")
        {
            Random random = new Random();
            CylinderNumber++;
            return new Cylinder(random.Next(minRandomValue, maxRandomValue), random.Next(minRandomValue, maxRandomValue), name);
        }
    }
}
