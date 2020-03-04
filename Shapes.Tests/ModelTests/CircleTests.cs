using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
    [TestClass]
    public class CircleTests
    {

        [TestMethod]

        public void Cirlce_GetArea_AreaofCircle()
        {
            Circle testCircle = new Circle(6);
            double area = testCircle.GetArea();
            Assert.AreEqual(area, 113.04);
        }
    }
}