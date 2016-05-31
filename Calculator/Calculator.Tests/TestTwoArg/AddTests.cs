using Calculator.TwoOperation;
using NUnit.Framework;

namespace Calculator.Tests.TestTwoArg
{
    [TestFixture]
    public class AddTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(2, 3, 5)]
        [TestCase(10, -12, -2)]
        public void SimpleTest(double firstarg, double seconarg, double expected)
        {
            Add calc = new Add();
            double result = calc.Calculate(firstarg, seconarg);
            Assert.AreEqual(expected, result);
        }
    }
}