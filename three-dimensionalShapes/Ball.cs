using HomeWork_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace three_dimensionalShapes
{
    internal class Ball : Shape
    {
        public Ball(double R, string name = "Шар")
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
            if (name != "Шар")
            {
                Name = name;
            }
            else
            {
                BallNumber++;
                Name = $"{name} {BallNumber}";
            }
            ExistNames.Add(Name);
        }

        private static int BallNumber { get; set; } = 0;


        /// <summary>
        /// Радиус шара.
        /// </summary>
        private double R { get; }

        /// <summary>
        /// Возвращает объем шара.
        /// </summary>
        public override double Volume()
        {
            return (4 / 3) * Math.PI * R;
        }

        /// <summary>
        /// Генерирует шар с произвольными размерами.
        /// </summary>
        public static Ball GetRandomBall(int minRandomValue = 1, int maxRandomValue = 20, string name = "Шар")
        {
            Random random = new Random();
            return new Ball(random.Next(minRandomValue, maxRandomValue), name);
        }
    }
}
