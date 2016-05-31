using Calculator.TwoOperation;
using NUnit.Framework;

namespace Calculator.Tests.TestTwoArg
{
    [TestFixture]
    public class AToXTests
    {
        [TestCase(25, -0.5, 0.2)]
        [TestCase(4, 3, 64)]
        [TestCase(10, -2, 0.01)]
        public void SimpleTest(double firstarg, double seconarg, double expected)
        {
            AToX calc = new AToX();
            double result = calc.Calculate(firstarg, seconarg);
            Assert.AreEqual(expected, result);
        }
    }
}