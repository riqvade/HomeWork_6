using HomeWork_6;
using Xunit;

namespace CalculatingPerimeterOfPolygon.Tests
{
    public class PolygonTests
    {
        [Fact]
        public void PerimeterOfThreePointPolygonTest()
        {
            // Arrange - Установка начальных значений
            Point p1 = new Point(1, 3, "p1");
            Point p2 = new Point(2, 4, "p2");
            Point p3 = new Point(7, 8, "p3");
            Polygon polygon = new Polygon(p1, p2, p3, "Многоугольник 1");

            // Act - Выполнение теста
            double perimeter = polygon.Perimeter();

            // Assert - Верификация результатов тестов
            Assert.Equal(15.628, perimeter, 3);
        }

        [Fact]
        public void PerimeterOfFourPointPolygonTest()
        {
            // Arrange - Установка начальных значений
            Point p1 = new Point(1, 3, "p1");
            Point p2 = new Point(4, 4, "p2");
            Point p3 = new Point(7, 1, "p3");
            Point p4 = new Point(11, 16, "p4");
            Polygon polygon = new Polygon(p1, p2, p3, p4, "Многоугольник 2");

            // Act - Выполнение теста
            double perimeter = polygon.Perimeter();

            // Assert - Верификация результатов тестов
            Assert.Equal(39.33, perimeter, 3);
        }

        [Fact]
        public void PerimeterOfFivePointPolygonTest()
        {
            // Arrange - Установка начальных значений
            Point p1 = new Point(1, 3, "p1");
            Point p2 = new Point(4, 4, "p2");
            Point p3 = new Point(7, 1, "p3");
            Point p4 = new Point(11, 16, "p4");
            Point p5 = new Point(3, 2, "p5");
            Polygon polygon = new Polygon(p1, p2, p3, p4, p5, "Многоугольник 3");

            // Act - Выполнение теста
            double perimeter = polygon.Perimeter();

            // Assert - Верификация результатов тестов
            Assert.Equal(41.29, perimeter, 3);
        }

        [Fact]
        public void PerimeterOfArrayPointPolygonTest()
        {
            // Arrange - Установка начальных значений
            Point p1 = new Point(1, 3, "p1");
            Point p2 = new Point(4, 4, "p2");
            Point p3 = new Point(7, 1, "p3");
            Point p4 = new Point(11, 16, "p4");
            Point p5 = new Point(3, 2, "p5");

            Point[] points = new Point[] { p1, p2, p3, p4, p5, };

            Polygon polygon = new Polygon(points, "Многоугольник 3");

            // Act - Выполнение теста
            double perimeter = polygon.Perimeter();

            // Assert - Верификация результатов тестов
            Assert.Equal(41.29, perimeter, 3);
        }
    }
}