using System;

namespace Calculator.Single
{
    public class Sqrt:IOneArg
    {
        public double Calc(double first)
        {
            if (first < 0)
            {
                throw new Exception("Корень отрицательного числа");
            }
            return Math.Sqrt(first);
        }
    }
}
