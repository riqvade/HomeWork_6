
using three_dimensionalShapes;

namespace HomeWork_6
{
    public abstract class Shape
    {
        public bool shapeIsAdded = false;
        protected Shape(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                shapeIsAdded = false;
                throw new ArgumentException("Empty shape name");
            }
            this.Name = name;

            shapeIsAdded = ShapeContainer.instance.addShape(this);
        }

        public abstract double Volume();

        public string? Name { get; set; }

        public override bool Equals(object? obj)
        {
            return obj is Shape shape && Name == shape.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }
    }
}
