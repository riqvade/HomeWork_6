using HomeWork_6;

namespace three_dimensionalShapes
{
    public class Box : Shape
    {
        public Box(double H, string name) : base(name)
        {
            this.H = H;
            BoxVolume = Volume();
        }

        /// <summary>
        /// Высота ребра куба.
        /// </summary>
        private double H { get; }

        /// <summary>
        /// Объем куба.
        /// </summary>
        private double BoxVolume { get; set; }
        private ISet<Shape> Shapes { get; set; } = new HashSet<Shape>();

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
            double shapeVolume = shape.Volume();
            if (shapeVolume > BoxVolume)
            {
                double surplusVolume = Math.Round(shapeVolume - BoxVolume, 3);
                
                return false;
            }
            BoxVolume -= shapeVolume;
            
            Shapes.Add(shape);
            

            return true;
        }

        public double GetFreeSpace()
        {
            return BoxVolume;
        }

        /// <summary>
        /// Выводит в консоль список фигур, добавленных в куб
        /// </summary>
        public void PrintFigures()
        {
            Console.WriteLine($"В фигуре \"{Name}\" находятся слудеющие фигуры:");
            foreach (Shape shape in Shapes)
            {
                Console.WriteLine($"\"{shape.Name}\" объемом: {Math.Round(shape.Volume(), 3)} м3");
            }
            Console.WriteLine($"В фигуре \"{Name}\" осталось: {Math.Round(BoxVolume, 3)} м3 из {Math.Round(Volume(), 3)} м3");
            Console.WriteLine();
        }
    }
}
