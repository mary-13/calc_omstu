using Calculator.TwoOperation;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class SubstractionTests
    {
        [TestCase(2, 2, 0)]
        [TestCase(2, 3, -1)]
        [TestCase(10, -12, 22)]
        public void SimpleTest(double firstarg, double seconarg, double expected)
        {
            Subtraction calc = new Subtraction();
            double result = calc.Calculate(firstarg, seconarg);
            Assert.AreEqual(expected, result);
        }
         
    }
}