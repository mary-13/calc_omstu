using System;
using Calculator.TwoOperation;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class DivisionTests
    {
        [TestCase(2, 2, 1)]
        [TestCase(2, 4, 0.5)]
        [TestCase(60, -12, -5)]
        public void SimpleTest(double firstarg, double seconarg, double expected)
        {
            Division calc = new Division();
            double result = calc.Calculate(firstarg, seconarg);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void DivisionByZeroTest()
        {
            Division calc = new Division();
            Assert.Throws<Exception>(() => calc.Calculate(5, 0));
            
        }
    }
}