using Calculator.TwoOperation;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class MultiplicationTests
    {
        [Test]
        public void SimpleTest()
        {
            Multiplication calc = new Multiplication();
            double result = calc.Calculate(2, 2);
            Assert.AreEqual(4, result);
        }
    }
}