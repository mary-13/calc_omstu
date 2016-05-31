using System;

namespace Calculator.TwoOperation
{
    public class Log:ICalculator
    {
        public double Calculate(double first, double second)
        {
            if ((second == 1)&&(second <= 0)&&(first <= 0))
            {
                throw new Exception("Введено неверное значение");
            }
            return Math.Log(first, second);
        }
    }
}
