using System;
using System.Collections.Generic;
using System.Text;

namespace GCDCalculator
{
    public class GcdBinary : ICalculation
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

            if (a == b)
                return a;

            if (a == 0)
                return b;

            if (b == 0)
                return a;

            if ((~a & 1) != 0)
            {
                if ((b & 1) != 0)
                    return GCD(a >> 1, b);
                else
                    return GCD(a >> 1, b >> 1) << 1;
            }

            if ((~b & 1) != 0)
                return GCD(a, b >> 1);

            if (a > b)
                return GCD((a - b) >> 1, b);

            return GCD((b - a) >> 1, a);
        }    
    }
}
