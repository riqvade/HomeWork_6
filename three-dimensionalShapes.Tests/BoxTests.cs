using Xunit;

namespace three_dimensionalShapes.Tests
{
    public class BoxTests
    {
        [Fact]
        public void VolumeOfBoxTest()
        {
            // Arrange - Установка начальных значений
            Box ball = new Box(4, "Куб");

            // Act - Выполнение теста
            double volumeOfBall = ball.Volume();

            // Assert - Верификация результатов тестов
            Assert.Equal(64.000, volumeOfBall, 3);
        }

        [Theory]
        [InlineData(9.0, 3.0, 2.0)]
        public void TestShapeAddition(double containerValue, double cylinderRadius, double cylinderHight)
        {
            // Arrange - Установка начальных значений
            Box box = new Box(containerValue, "box");
            Cylinder cylinder = new Cylinder(cylinderRadius, cylinderHight, "cylinder");

            // Assert - Верификация результатов тестов
            Assert.True(box.Add(cylinder));
        }


    }
}
