using HomeWork_6;

namespace three_dimensionalShapes
{
    internal class Ball : Shape
    {
        public Ball(double R, string name) : base(name)
        {
            this.R = R;
        }

        /// <summary>
        /// Радиус шара.
        /// </summary>
        private double R { get; }

        /// <summary>
        /// Возвращает объем шара.
        /// </summary>
        public override double Volume()
        {
            return Math.PI * 4 / 3 * R;
        }
    }
}
