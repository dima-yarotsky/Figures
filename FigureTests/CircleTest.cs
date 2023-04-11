using Figures;
namespace FigureTests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void CircleResultArea()
        {
            double expected = 17.27;  

            var circle = new Circle(2.75);
            double result = circle.getArea();
            Assert.AreEqual(expected, result);
        }
    }
}