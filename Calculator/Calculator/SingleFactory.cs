using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class SingleFactory
    {
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
