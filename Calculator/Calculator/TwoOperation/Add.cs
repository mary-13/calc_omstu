namespace Calculator.TwoOperation
{
    public class Add:ICalculator
    {
        /// <summary>
        /// Calculation of addition
        /// </summary>
        /// <param name="first">tranfer first input value
        /// </param>
        /// <param name="second">tranfer second input value
        /// </param>
        /// <returns>return argument
        /// </returns>
        public double Calculate(double first, double second)
        {
            return first + second;
        }
    }
}
