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

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
