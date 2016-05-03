using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Tg:IOneArg
    {
        public double Calc(double first)
        {
            return Math.Tan(first);
        }
    }
}
