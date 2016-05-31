using System;

namespace Calculator.TwoOperation
{
    public class Division : ICalculator
    {
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("Деление на ноль");
            }
            return first / second;
        }
    }
}
