using System;
using Calculator.Single;
using NUnit.Framework;

namespace Calculator.Tests.TestOneArg
{
    [TestFixture]
    public class LnTests
    {
        [TestCase(1, 0)]
        [TestCase(5, 1.6094)]
        [TestCase(8, 2.0794)]
        public void SimpleTest(double firstarg, double expected)
        {
            Ln calc = new Ln();
            double result = calc.Calc(firstarg);
            Assert.AreEqual(expected, result, 0.0001);
        }
        [Test]
        public void BaseLogarithmOfZeroTest()
        {
            Ln calc = new Ln();
            Assert.Throws<Exception>(() => calc.Calc(-3));
        }

    }
}