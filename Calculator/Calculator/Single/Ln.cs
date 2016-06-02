using System;

namespace Calculator.Single
{
    public class Ln:IOneArg
    {
        public double Calc(double first)
        {
            if (first <= 0)
            {
                throw new Exception("Введено неверное значение");
            }
            return Math.Log(first);
        }
    }
}
