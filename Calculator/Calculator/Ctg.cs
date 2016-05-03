using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Ctg:IOneArg
    {
        public double Calc(double first)
        {
            return 1/Math.Tan(first);
        }
    }
}
