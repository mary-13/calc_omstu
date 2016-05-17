using Calculator.TwoOperation;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class AddTests
    {
        [Test]
        public void SimpleTest()
        {
            Add calc = new Add();
            double result = calc.Calculate(2, 2);
            Assert.AreEqual(4,result);
        }
    }
}