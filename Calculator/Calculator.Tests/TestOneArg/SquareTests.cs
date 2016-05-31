using Calculator.Single;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class SquareTests
    {
        [TestCase(-1, 1)]
        [TestCase(5, 25)]
        [TestCase(-1.5, 2.25)]
        public void SimpleTest(double firstarg, double expected)
        {
            Square calc = new Square();
            double result = calc.Calc(firstarg);
            Assert.AreEqual(expected, result);
        } 
    }
}