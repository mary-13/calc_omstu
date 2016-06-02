using System;
using Calculator.Single;

namespace Calculator
{
    public static class SingleFactory
    {
        /// <summary>
        /// Button's job for one argument
        /// </summary>
        /// <param name="name"> transfer button's name
        /// </param>
        /// <returns> return class
        /// </returns>
        public static IOneArg CreateCalc(string name)
        {
            switch (name)
            {
                case "button5":
                    return new Sin();

                case "button6":
                    return new Cos();

                case "button9":
                    return new Tg();

                case "button12":
                    return new Ctg();

                case "button7":
                    return new Ln();

                case "button13":
                    return new Log10();

                case "button8":
                    return new Exp();

                case "button11":
                    return new Square();

                case "button15":
                    return new Sqrt();

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
