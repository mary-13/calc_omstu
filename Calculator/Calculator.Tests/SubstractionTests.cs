using Calculator.TwoOperation;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class SubstractionTests
    {
        [Test]
        public void SimpleTest()
        {
            Subtraction calc = new Subtraction();
            double result = calc.Calculate(2, 2);
            Assert.AreEqual(0, result);
        }
         
    }
}