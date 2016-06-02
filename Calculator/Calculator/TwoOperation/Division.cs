using System;

namespace Calculator.TwoOperation
{
    public class Division : ICalculator
    {
        /// <summary>
        /// Calculation of division
        /// </summary>
        /// <param name="first">tranfer first input value
        /// </param>
        /// <param name="second">tranfer second input value
        /// </param>
        /// <returns>return argument 
        /// </returns>
        public double Calculate(double first, double second)
        {
            if (second == 0)
            {
                throw new Exception("Деление на ноль");
            }
            return first / second;
        }
    }
}
