using Calculator.Single;
using NUnit.Framework;

namespace Calculator.Tests.TestOneArg
{
    [TestFixture]
    public class SinTests
    {
        [TestCase(0, 0)]
        [TestCase(5, -0.9589243)]
        [TestCase(1, 0.8414710)]
        public void SimpleTest(double firstarg, double expected)
        {
            Sin calc = new Sin();
            double result = calc.Calc(firstarg);
            Assert.AreEqual(expected, result, 0.0000001);
        }    
    }
}