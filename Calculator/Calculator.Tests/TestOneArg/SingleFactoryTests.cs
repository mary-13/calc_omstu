using System;
using Calculator.Single;
using NUnit.Framework;

namespace Calculator.Tests.TestOneArg
{
    public class SingleFactoryTests
    {
        [TestCase("button5", typeof (Sin))]
        [TestCase("button6", typeof (Cos))]
        [TestCase("button9", typeof (Tg))]
        [TestCase("button12", typeof (Ctg))]
        [TestCase("button7", typeof (Ln))]
        [TestCase("button13", typeof (Log10))]
        [TestCase("button8", typeof (Exp))]
        [TestCase("button11", typeof (Square))]
        [TestCase("button15", typeof (Sqrt))]
        public void CreateCalcTest(string name, Type type)
        {
            IOneArg calc = SingleFactory.CreateCalc(name);
            Assert.IsInstanceOf(type,calc);
        }
    }
}