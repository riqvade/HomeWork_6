using Xunit;

namespace three_dimensionalShapes.Tests
{
    public class BallTests
    {
        [Fact]
        public void VolumeOfBallTest()
        {
            // Arrange - ��������� ��������� ��������
            Ball ball = new Ball(100, "���");

            // Act - ���������� �����
            double volumeOfBall = ball.Volume();

            // Assert - ����������� ����������� ������
            Assert.Equal(418.879, volumeOfBall, 3);
        }
    }
}