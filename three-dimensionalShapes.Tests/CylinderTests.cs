using Xunit;

namespace three_dimensionalShapes.Tests
{
    public class CylinderTests
    {
        [Fact]
        public void VolumeOfBoxTest()
        {
            // Arrange - Установка начальных значений
            Cylinder cylinder = new Cylinder(2, 8, "Цилиндр");

            // Act - Выполнение теста
            double volumeOfCylinder = cylinder.Volume();

            // Assert - Верификация результатов тестов
            Assert.Equal(100.531, volumeOfCylinder, 3);
        }
    }
}
