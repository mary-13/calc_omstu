using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Square:IOneArg
    {
        public double Calc(double first)
        {
            return first*first;
        }
    }
}
