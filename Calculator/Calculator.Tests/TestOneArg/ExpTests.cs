using Calculator.Single;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Calculator.Tests
{
    [TestFixture]
    public class ExpTests
    {
        [TestCase(0, 1)]
        [TestCase(5, 148.4132)]
        [TestCase(1, 2.7183)]
        public void SimpleTest(double firstarg, double expected)
        {
            Exp calc = new Exp();
            double result = calc.Calc(firstarg);
            Assert.AreEqual(expected, result, 0.0001);
        } 
    }
}