using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Log10:IOneArg
    {
        public double Calc(double first)
        {
            return Math.Log10(first);
        }
    }
}
