using Calculator.TwoOperation;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class DivisionTests
    {
        [Test]
        public void SimpleTest()
        {
            Division calc = new Division();
            double result = calc.Calculate(2, 2);
            Assert.AreEqual(1, result);
        }
    }
}