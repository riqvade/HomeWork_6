using HomeWork_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace three_dimensionalShapes
{
    internal class Pyramid : Shape
    {
        public Pyramid(double S, double H, string name = "Пирамида")
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

            this.S = S;
            this.H = H;
            if(name != "Пирамида")
            {
                Name = name;
            }
            else
            {
                PyramidNumber++;
                Name = $"{name} {PyramidNumber}";
            }
            ExistNames.Add(Name);
        }

        private static int PyramidNumber { get; set; } = 0;

        /// <summary>
        /// Площадь основания пирамиды.
        /// </summary>
        private double S { get; }

        /// <summary>
        /// Высота пирамиды.
        /// </summary>
        private double H { get; }

        /// <summary>
        /// Возвращает объем пирамиды.
        /// </summary>
        public override double Volume()
        {
            return (S * H) / 3;
        }

        /// <summary>
        /// Генерирует пирамиду с произвольными размерами.
        /// </summary>
        public static Pyramid GetRandomPyramid(int minRandomValue = 1, int maxRandomValue = 20, string name = "Пирамида")
        {
            Random random = new Random();
            return new Pyramid(random.Next(minRandomValue, maxRandomValue), random.Next(minRandomValue, maxRandomValue), name);
        }
    }
}
