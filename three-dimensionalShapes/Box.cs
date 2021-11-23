using HomeWork_6;

namespace three_dimensionalShapes
{
    internal class Box : Shape
    {
        public Box(double H, string name) : base(name)
        {
            this.H = H;
            V = Volume();
        }

        /// <summary>
        /// Высота ребра куба.
        /// </summary>
        private double H { get; }

        /// <summary>
        /// Объем куба.
        /// </summary>
        private double V { get; set; }
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
            if (shapeVolume > V)
            {
                double surplusVolume = Math.Round(shapeVolume - V, 3);
                
                return false;
            }
            shape.parent = this;
            V -= shapeVolume;
            
            Shapes.Add(shape);
            

            return true;
        }

        public double GetFreeSpace()
        {
            return V;
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
            Console.WriteLine($"В фигуре \"{Name}\" осталось: {Math.Round(V, 3)} м3 из {Math.Round(Volume(), 3)} м3");
            Console.WriteLine();
        }
    }
}
