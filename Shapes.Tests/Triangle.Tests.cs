using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
    [TestClass]
    public class TriangleTests
    {

        [TestMethod]

        public void GetArea_BaseTimesHeightDivideByTwo_ReturnArea()
        {
            Triangle testTriangle = new Triangle(5, 6);
            double area = testTriangle.GetArea();
            Assert.AreEqual(area, 15);
        }
    }
}