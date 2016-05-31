using System;
using Calculator.Single;
using NUnit.Framework;

namespace Calculator.Tests.TestOneArg
{
    [TestFixture]
    public class SqrtTests
    {
        [TestCase(25, 5)]
        [TestCase(2.25, 1.5)]
        [TestCase(1, 1)]
        public void SimpleTest(double firstarg, double expected)
        {
            Sqrt calc = new Sqrt();
            double result = calc.Calc(firstarg);
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void SqrtOfNegativeNumberTest()
        {
            Sqrt calc = new Sqrt();
            Assert.Throws<Exception>(() => calc.Calc(-2)); 
        }
    }
}