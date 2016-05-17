using System;

namespace Calculator.Single
{
    public class Sqrt:IOneArg
    {
        public double Calc(double first)
        {
            return Math.Sqrt(first);
        }
    }
}
