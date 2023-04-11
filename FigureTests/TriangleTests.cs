using Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureTests
{
    public class TriangleTests
    {
        [TestMethod]
        public void TriangleResultArea()
        {
            double expected = 34.4674;

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
    }
}
