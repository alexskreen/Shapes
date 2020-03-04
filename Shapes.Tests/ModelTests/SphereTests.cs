using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
    [TestClass]
    public class SphereTests
    {
        [TestMethod]

        public void GetVolume_CalculateVolume_ReturnVolume()
        {
            Circle testCircle = new Circle(6);
            Sphere testSphere = new Sphere(testCircle);
            double volume = testSphere.GetVolume();
            Assert.AreEqual(volume, 904.78);
        }

    }
}