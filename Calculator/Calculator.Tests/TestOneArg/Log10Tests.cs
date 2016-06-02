using System;
using Calculator.Single;
using NUnit.Framework;

namespace Calculator.Tests.TestOneArg
{
    public class Log10Tests
    {
        [TestCase(10, 1)]
        [TestCase(1, 0)]
        [TestCase(100, 2)]
        public void SimpleTest(double firstarg, double expected)
        {
            Log10 calc = new Log10();
            double result = calc.Calc(firstarg);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void BaseLogarithmOfZeroTest()
        {
            Log10 calc = new Log10();
            Assert.Throws<Exception>(() => calc.Calc(0)); //сбой теста
        }

        [Test]
        public void LogarithmOfZeroTest()
        {
            Log10 calc = new Log10();
            Assert.Throws<Exception>(() => calc.Calc(-2)); //сбой теста
        }
    }
}