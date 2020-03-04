using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
    [TestClass]
    public class CubeTests
    {

        [TestMethod]
        public void Cube_GetVolume_VolumeOfCube()
        {
            // Arrange
            Rectangle newRectangle = new Rectangle(4, 4);
            CubeRec newCubeRec = new CubeRec(newRectangle);
            // Act
            int result = newCubeRec.GetVolume();
            // Assert
            Assert.AreEqual(result, 64);
        }
        [TestMethod]
        public void CubeRec_GetSurfaceArea_SurfaceAreaOfCubeRec()
        {
            // Arrange
            Rectangle newRectangle = new Rectangle(4, 4);
            CubeRec newCubeRec = new CubeRec(newRectangle);
            // Act
            int result = newCubeRec.GetSurfaceArea();
            // Assert
            Assert.AreEqual(result, 96);
        }

        [TestMethod]
        public void Square_GetAre_AreaOfSquare()
        {
            // Arrange
            Square newSquare = new Square(4, 4);
            // Act
            int result = newSquare.GetArea();
            // Assert
            Assert.AreEqual(result, 16);
        }

        [TestMethod]
        public void CubeSq_GetVolume_VolumeOfCube()
        {
            // Arrange
            Square newSquare = new Square(4, 4);
            CubeSq newCubeSq = new CubeSq(newSquare);
            // Act
            int result = newCubeSq.GetVolume();
            // Assert
            Assert.AreEqual(result, 64);
        }
        [TestMethod]
        public void CubSq_GetSurfaceArea_SurfaceAreaOfCube()
        {
            // Arrange
            Square newSquare = new Square(4, 4);
            CubeSq newCubeSq = new CubeSq(newSquare);
            // Act
            int result = newCubeSq.GetSurfaceArea();
            // Assert
            Assert.AreEqual(result, 96);
        }

    }
}