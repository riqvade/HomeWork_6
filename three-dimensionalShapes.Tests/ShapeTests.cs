using Xunit;

namespace three_dimensionalShapes.Tests
{
    public class ShapeTests
    {
        [Fact]
        public void AddedShapeBoolTest()
        {
            // Arrange - Установка начальных значений
            Box box = new Box(12, "box");
            Cylinder cylinder = new Cylinder(3, 5, "cylinder");

            // Act - Выполнение теста
            box.Add(cylinder);

            // Assert - Верификация результатов тестов
            Assert.True(box.shapeIsAdded);
        }

        [Fact]
        public void AddedShapeStringTest()
        {
            // Arrange - Установка начальных значений
            Box box = new Box(12, "box");
            Cylinder cylinder = new Cylinder(3, 5, "cylinder");

            // Act - Выполнение теста
            box.Add(cylinder);

            // Assert - Верификация результатов тестов
            Assert.True(ShapeContainer.instance.existingShapes.Contains(cylinder));
        }
    }
}
