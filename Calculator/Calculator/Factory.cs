﻿using System;
using Calculator.TwoOperation;

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

                case "button10":
                    return new Log();

                case "button14":
                    return new AToX();

                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
