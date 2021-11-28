using HomeWork_6;

namespace three_dimensionalShapes
{
    public class Ball : Shape
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
            return Math.PI * 4.0 / 3.0 * R;
        }
    }
}
