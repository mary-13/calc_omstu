using Calculator.Single;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Calculator.Tests
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
    }
}