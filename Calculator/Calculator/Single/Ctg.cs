using System;

namespace Calculator.Single
{
    public class Ctg:IOneArg
    {
        public double Calc(double first)
        {
            return 1/Math.Tan(first);
        }
    }
}
