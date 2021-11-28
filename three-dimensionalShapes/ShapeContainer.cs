using HomeWork_6;

namespace three_dimensionalShapes
{
    public class ShapeContainer
    {
        public static ShapeContainer instance = new ShapeContainer();

        public ISet<Shape> existingShapes = new HashSet<Shape>();
        public bool addShape(Shape shape)
        {
            if (existingShapes.Contains(shape))
            {
                return false;
                throw new ArgumentException("Shape with this name already exists");
            }
            existingShapes.Add(shape);
            return true;
        }
    }
}
