using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace GCDCalculator
{
    public class GcdRecursive : ICalculation
    {
        public int GCD(int a, int b)
        {
            if (a < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (b < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            return (b == 0) ? a : GCD(b, a % b);
        }
    }
}
