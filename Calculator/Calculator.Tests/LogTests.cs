using Calculator.TwoOperation;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Calculator.Tests
{
    [TestFixture]
    public class LogTests
    {
        [TestCase(2, 2, 4)]
        [TestCase(2, 3, 6)]
        [TestCase(10, -12, -120)]
        public void SimpleTest(double firstarg, double seconarg, double expected)
        {
            Log calc = new Log();
            double result = calc.Calculate(firstarg, seconarg);
            Assert.AreEqual(expected, result);
        } 
    }
}