using System;
using Calculator.Single;
using NUnit.Framework;

namespace Calculator.Tests.TestOneArg
{
    [TestFixture]
    public class TgTests
    {
        [TestCase(0, 0)]
        [TestCase(5, -3.380515)]
        [TestCase(-2, 2.185040)]
        public void SimpleTest(double firstarg, double expected)
        {
            Tg calc = new Tg();
            double result = calc.Calc(firstarg);
            Assert.AreEqual(expected, result, 0.000001);
        }
   //     [Test]
     //   public void TgExceptionTest()
       // {
         //   Tg calc = new Tg();
           // Assert.Throws<Exception>(() => calc.Calc(1.5708)); 
        //}
    }
}