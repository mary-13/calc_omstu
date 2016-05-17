using System;

namespace Calculator.TwoOperation
{
    public class Log:ICalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Log(first, second);
        }
    }
}
