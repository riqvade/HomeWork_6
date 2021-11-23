
using three_dimensionalShapes;

namespace HomeWork_6
{
    internal abstract class Shape
    {
        public Shape parent = null;
        protected Shape(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Empty shape name");
            }
            this.Name = name;

            ShapeContainer.instance.addShape(this);
        }

        public abstract double Volume();

        public void setParent(Shape shape)
        {
            this.parent = shape;
        }
        public string? Name { get; set; }

        public string? Added { get; set; }

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
