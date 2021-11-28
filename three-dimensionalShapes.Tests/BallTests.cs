using Xunit;

namespace three_dimensionalShapes.Tests
{
    public class BallTests
    {
        [Fact]
        public void VolumeOfBallTest()
        {
            // Arrange - Установка начальных значений
            Ball ball = new Ball(100, "Шар");

            // Act - Выполнение теста
            double volumeOfBall = ball.Volume();

            // Assert - Верификация результатов тестов
            Assert.Equal(418.879, volumeOfBall, 3);
        }
    }
}