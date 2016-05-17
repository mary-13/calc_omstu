using System;

namespace Calculator.Single
{
    public class Ln:IOneArg
    {
        public double Calc(double first)
        {
            return Math.Log(first);
        }
    }
}
