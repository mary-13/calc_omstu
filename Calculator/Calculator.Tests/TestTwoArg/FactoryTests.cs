using System;
using Calculator.TwoOperation;
using NUnit.Framework;

namespace Calculator.Tests.TestTwoArg
{
    public class FactoryTests
    {
        [TestCase("button1", typeof(Add))]
        [TestCase("button2", typeof(Subtraction))]
        [TestCase("button3", typeof(Multiplication))]
        [TestCase("button4", typeof(Division))]
        [TestCase("button10", typeof(Log))]
        [TestCase("button14", typeof(AToX))]
      
        public void CreateCalcTest(string name, Type type)
        {
            ICalculator calc = Factory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calc);
        } 
    }
}