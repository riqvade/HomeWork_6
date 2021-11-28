using HomeWork_6;

namespace three_dimensionalShapes
{
    public class Pyramid : Shape
    {
        public Pyramid(double S, double H, string name) : base(name)
        {
            this.S = S;
            this.H = H;
        }

        /// <summary>
        /// Площадь основания пирамиды.
        /// </summary>
        private double S { get; }

        /// <summary>
        /// Высота пирамиды.
        /// </summary>
        private double H { get; }

        public override double Volume()
        {
            return (S * H) / 3.0;
        }
    }
}
