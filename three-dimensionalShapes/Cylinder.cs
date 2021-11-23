using HomeWork_6;

namespace three_dimensionalShapes
{
    internal class Cylinder : Shape
    {
        public Cylinder(double R, double H, string name) : base(name)
        {
            this.R = R;
            this.H = H;
        }

        /// <summary>
        /// Радиус основания циллиндра.
        /// </summary>
        private double R { get; }

        /// <summary>
        /// Высота цилиндра.
        /// </summary>
        private double H { get; }

        /// <summary>
        /// Возвращает объем циллиндра.
        /// </summary>
        public override double Volume()
        {
            return Math.PI * Math.Pow(R, 2) * H;
        }
    }
}
