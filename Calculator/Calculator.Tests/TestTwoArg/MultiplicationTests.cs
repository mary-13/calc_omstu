using Calculator.TwoOperation;
using NUnit.Framework;

namespace Calculator.Tests.TestTwoArg
{
    [TestFixture]
    public class MultiplicationTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(2, 3, 6)]
        [TestCase(10, -12, -120)]
        public void SimpleTest(double firstarg, double seconarg, double expected)
        {
            Multiplication calc = new Multiplication();
            double result = calc.Calculate(firstarg, seconarg);
            Assert.AreEqual(expected, result);
        }
    }
}