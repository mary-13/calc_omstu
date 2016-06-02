using System;
using Calculator.Single;
using NUnit.Framework;

namespace Calculator.Tests.TestOneArg
{
    [TestFixture]
    public class CtgTests
    {
        [TestCase(1, 0.6420926)]
        [TestCase(5, -0.2958129)]
        [TestCase(-2, 0.4576576)]
        public void SimpleTest(double firstarg, double expected)
        {
            Ctg calc = new Ctg();
            double result = calc.Calc(firstarg);
            Assert.AreEqual(expected, result, 0.0000001);
        }    
        [Test]
         public void TgExceptionTest()
         {
              Ctg calc = new Ctg();
              Assert.Throws<Exception>(() => calc.Calc(0)); 
         }
    }
}