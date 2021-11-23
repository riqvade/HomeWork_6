using HomeWork_6;

namespace three_dimensionalShapes
{
    internal class ShapeContainer
    {
        public static ShapeContainer instance = new ShapeContainer();

        private ISet<Shape> existingShapes = new HashSet<Shape>();
        public void addShape(Shape shape)
        {
            if (existingShapes.Contains(shape))
            {
                throw new ArgumentException("Shape with this name already exists");
            }
            existingShapes.Add(shape);
        }
    }
}
