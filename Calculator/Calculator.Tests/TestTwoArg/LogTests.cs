using Calculator.TwoOperation;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class LogTests
    {
        [TestCase(2, 2, 1)]
        [TestCase(4, 16, 0.5)]
        [TestCase(1, 8, 0)]
        public void SimpleTest(double firstarg, double seconarg, double expected)
        {
            Log calc = new Log();
            double result = calc.Calculate(firstarg, seconarg);
            Assert.AreEqual(expected, result);
        }
        
    }


}