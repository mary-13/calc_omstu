using System;

namespace Calculator.Single
{
    public class Ctg:IOneArg
    {
        /// <summary>
        /// Calculation of Ctg
        /// </summary>
        /// <param name="first"> tranfer input value
        /// </param>
        /// <returns> return argument
        /// </returns>
        public double Calc(double first)
        {
            if ((first == 0)||(first == Math.PI))
            {
                throw new Exception("Введено неверное значение");
            }
            return 1/Math.Tan(first);
        }
    }
}
