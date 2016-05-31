using Calculator.Single;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class SqrtTests
    {
        [TestCase(25, 5)]
        [TestCase(2.25, 1.5)]
        [TestCase(1, 1)]
        public void SimpleTest(double firstarg, double expected)
        {
            Sqrt calc = new Sqrt();
            double result = calc.Calc(firstarg);
            Assert.AreEqual(expected, result);
        } 
    }
}