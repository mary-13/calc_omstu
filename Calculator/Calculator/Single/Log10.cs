using System;

namespace Calculator.Single
{
    public class Log10:IOneArg
    {
        public double Calc(double first)
        {
            return Math.Log10(first);
        }
    }
}
