using System;

namespace Calculator.Single
{
    public class Tg:IOneArg
    {
        public double Calc(double first)
        {
            if ((first == Math.PI/2) || (first == 3*Math.PI/2))
            {
                throw new Exception("Введено неверное значение");
            }
            return Math.Tan(first);
        }
    }
}
