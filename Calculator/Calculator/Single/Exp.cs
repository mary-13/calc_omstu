using System;

namespace Calculator.Single
{
    public class Exp:IOneArg
    {
        public double Calc(double first)
        {
            return Math.Exp(first);
        }
    }
}
