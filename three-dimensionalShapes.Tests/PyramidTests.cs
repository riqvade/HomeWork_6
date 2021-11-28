using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace three_dimensionalShapes.Tests
{
    public class PyramidTests
    {
        [Fact]
        public void VolumeOfPyramidTest()
        {
            // Arrange - Установка начальных значений

            Pyramid pyramid = new Pyramid(5, 8, "Пирамида");

            // Act - Выполнение теста
            double volumeOfpyramid = pyramid.Volume();

            // Assert - Верификация результатов тестов
            Assert.Equal(13.333, volumeOfpyramid, 3);
        }
    }
}
