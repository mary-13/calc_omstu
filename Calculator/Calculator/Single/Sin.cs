using System;

namespace Calculator.Single
{
    public class Sin : IOneArg
    {
        public double Calc(double first)
        {
            return Math.Sin(first);
        }
    }
}
