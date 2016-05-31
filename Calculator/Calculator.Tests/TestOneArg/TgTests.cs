using Calculator.Single;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class TgTests
    {
        [TestCase(0, 0)]
        [TestCase(5, -3.380515)]
        [TestCase(-2, 2.185040)]
        public void SimpleTest(double firstarg, double expected)
        {
            Tg calc = new Tg();
            double result = calc.Calc(firstarg);
            Assert.AreEqual(expected, result, 0.000001);
        } 
    }
}