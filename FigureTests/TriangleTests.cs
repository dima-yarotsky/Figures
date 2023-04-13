using Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TriangleResultArea()
        {
            double expected = 34.46737587922817;

            var triangle = new Triangle(7, 12, 17);
            double result = triangle.getArea();
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void isRightTriangleFalce()
        {
            bool expected = false;

            var triangle = new Triangle(7, 12, 17);
            bool result = triangle.RightTriangle();
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void isRightTriangleTrue()
        {
            bool expected = true;

            var triangle = new Triangle(7, 24, 25);
            bool result = triangle.RightTriangle();
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void expectionSidesZero()
        {
            Triangle triangle = new(0, 5, 45);
            var getArea = Assert.ThrowsException<FigureException>(() => triangle.getArea());
            Assert.AreSame(getArea.Message, "Incorrect sides");
        }
        [TestMethod]
        public void expectionSides()
        {
            Triangle triangle = new(-1, 5, 45);
            var getArea = Assert.ThrowsException<FigureException>(() => triangle.getArea());
            Assert.AreSame(getArea.Message, "Incorrect sides");
        }
        [TestMethod]
        public void expectionTriangle()
        {
            Triangle triangle = new(2, 5, 45);
            var getArea = Assert.ThrowsException<FigureException>(() => triangle.getArea());
            Assert.AreSame(getArea.Message, "Incorrect triangle");

        }
    }
}
