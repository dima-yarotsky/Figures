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
        [TestMethod]
        public void expectionRadius()
        {
            Circle circle = new Circle(0);
            var getArea = Assert.ThrowsException<FigureException>(() => circle.getArea());
            Assert.AreSame(getArea.Message, "Incorrect radius");

        }
    }
}