using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Factory
    {
        public static ICalculator CreateCalculator (string name)
        {
            switch (name)
            {
                case "button1":
                    return new Add();
                    
                case "button2":
                    return new Subtraction();

                case "button3":
                    return new Multiplication();

                case "button4":
                    return new Division();

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
