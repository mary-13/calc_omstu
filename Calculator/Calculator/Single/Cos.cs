using System;

namespace Calculator.Single
{
    public class Cos : IOneArg
    {
        /// <summary>
        /// Calculation of cos
        /// </summary>
        /// <param name="first"> tranfer input value
        /// </param>
        /// <returns> return argument 
        /// </returns>
        public double Calc(double first)
        {
            return Math.Cos(first);
        }
    }
}
