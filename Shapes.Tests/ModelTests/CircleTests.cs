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
        [TestMethod]

        public void Cirlce_GetCircumference_CircumferenceOfCircle()
        {
            Circle testCircle = new Circle(6);
            double area = testCircle.GetCicumference();
            Assert.AreEqual(area, 37.70);
        }

    }
}