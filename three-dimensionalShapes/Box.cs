using HomeWork_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace three_dimensionalShapes
{
    internal class Box : Shape
    {
        public Box(double H, string name = "Куб")
        {
            foreach(string existName in ExistNames)
            {
                if (existName.Equals(name))
                {
                    Console.WriteLine($"Фигура с именем {name} уже существует, выберите другое нименование фигуры!");
                    Console.WriteLine();
                    return;
                }
            }
            this.H = H;
            V = Volume();
            if (name != "Куб")
            {
                Name = name;
            }
            else
            {
                BoxNumber++;
                Name = $"{name} {BoxNumber}";
            }
            Console.WriteLine($"Создан объект-контейнер: {Name}, объемом: {V} м3");
            Console.WriteLine();
            ExistNames.Add(Name);
        }

        private static int BoxNumber { get; set; } = 0;

        /// <summary>
        /// Высота ребра куба.
        /// </summary>
        private double H { get; }

        /// <summary>
        /// Объем куба.
        /// </summary>
        private double V { get; set; }
        private List<Shape> Shapes { get; set; } = new List<Shape>();

        /// <summary>
        /// Возвращает объем куба.
        /// </summary>
        public override double Volume()
        {
            return Math.Pow(H, 3);
        }

        /// <summary>
        /// Добавляет фигуру в куб.
        /// </summary>
        public bool Add(Shape shape)
        {
            if (string.IsNullOrEmpty(shape.Name))
            {
                return false;
            }

            if(!string.IsNullOrEmpty(shape.Added))
            {
                Console.WriteLine(shape.Added);
                Console.WriteLine($"Фигура не добавлена!");
                Console.WriteLine();

                return false;
            }

            bool flag = false;
            double shapeVolume = shape.Volume();
            if (shape.Volume() <= V)
            {

                Console.WriteLine($"В фигуру \"{Name}\" добавлена фигура: \"{shape.Name}\" объемом: {Math.Round(shape.Volume(), 3)} м3");
                V = V - shapeVolume;
                Shapes.Add(shape);
                Console.WriteLine($"Осталось: {Math.Round(V, 3)} м3 из {Math.Round(Volume(), 3)} м3");

                shape.Added = $"Фигура \"{shape.Name}\" уже добавлена в фигуру-контейнер: \"{Name}\"";

                flag = true;
            }
            else
            {
                Console.WriteLine($"Фигура: \"{shape.Name}\" объемом: {Math.Round(shape.Volume(), 3)} м3 не добавлена");
                Console.WriteLine($"Для добавления фигуры {shape.Name}, не хватает: {Math.Round(V - shape.Volume(), 3) * -1} м3");
            }
            Console.WriteLine();

            return flag;
        }

        /// <summary>
        /// Выводит в консоль список фигур, добавленных в куб
        /// </summary>
        public void PrintFigures()
        {
            Console.WriteLine($"В фигуре \"{Name}\" находятся слудеющие фигуры:");
            for (int i = 0; i < Shapes.Count; i++)
            {
                Console.WriteLine($"\"{Shapes[i].Name}\" объемом: {Math.Round(Shapes[i].Volume(), 3)} м3");
            }
            Console.WriteLine($"В фигуре \"{Name}\" осталось: {Math.Round(V, 3)} м3 из {Math.Round(Volume(), 3)} м3");
            Console.WriteLine();
        }

        /// <summary>
        /// Генерирует куб с произвольными размерами.
        /// </summary>
        public static Box GetRandomCylinder(int minRandomValue = 1, int maxRandomValue = 20, string name = "Цилиндр")
        {
            Random random = new Random();
            return new Box(random.Next(minRandomValue, maxRandomValue), name);
        }
    }
}
