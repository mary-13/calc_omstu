using Calculator.Single;
using NUnit.Framework;

namespace Calculator.Tests
{
   
        [TestFixture]
        public class CosTests
        {
            [TestCase(0, 1)]
            [TestCase(5, 0.28366219)]
            [TestCase(1, 0.54030231)]
            public void SimpleTest(double firstarg, double expected)
            {
                Cos calc = new Cos();
                double result = calc.Calc(firstarg);
                Assert.AreEqual(expected, result, 0.00000001);
            }
        } 
    
}