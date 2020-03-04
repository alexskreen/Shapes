using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
    [TestClass]
    public class PyramidTests
    {

        [TestMethod]

        public void GetArea_BaseTimesHeightDivideByTwo_ReturnArea()
        {
            Triangle testTriangle = new Triangle(5, 6);
            Pyramid testPyramid = new Pyramid(testTriangle, 6);
            double area = testPyramid.GetVolume();
            Assert.AreEqual(area, 60);
        }
    }
}