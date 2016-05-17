using System;

namespace Calculator.TwoOperation
{
    public class AToX:ICalculator
    {
        public double Calculate(double first, double second)
        {
            return Math.Pow(first, second);
        }
    }
}
