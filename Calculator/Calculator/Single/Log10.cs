using System;

namespace Calculator.Single
{
    public class Log10:IOneArg
    {
        public double Calc(double first)
        {
            if (first <= 0)
            {
                throw new Exception("Введено неверное значение");
            }
            return Math.Log10(first);
        }
    }
}
