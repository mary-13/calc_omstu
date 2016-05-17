using System;

namespace Calculator.Single
{
    public class Cos : IOneArg
    {
        public double Calc(double first)
        {
            return Math.Cos(first);
        }
    }
}
