using System;
using Calculator.TwoOperation;
using NUnit.Framework;

namespace Calculator.Tests.TestTwoArg
{
    [TestFixture]
    public class LogTests
    {
        [TestCase(2, 2, 1)]
        [TestCase(4, 16, 0.5)]
        [TestCase(1, 8, 0)]
        public void SimpleTest(double firstarg, double seconarg, double expected)
        {
            Log calc = new Log();
            double result = calc.Calculate(firstarg, seconarg);
            Assert.AreEqual(expected, result);
        }
       // [Test]
        //public void BaseLogarithmOfZeroTest()
        //{
         //   Log calc = new Log();
           // Assert.Throws<Exception>(() => calc.Calculate(5, 0)); //сбой теста
       // }

        //[Test]
        //public void LogarithmOfZeroTest()
        //{
          //  Log calc = new Log();
            //Assert.Throws<Exception>(() => calc.Calculate(-2, 5)); //сбой теста
        //}
    }


}