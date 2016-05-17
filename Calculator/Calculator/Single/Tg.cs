using System;

namespace Calculator.Single
{
    public class Tg:IOneArg
    {
        public double Calc(double first)
        {
            return Math.Tan(first);
        }
    }
}
