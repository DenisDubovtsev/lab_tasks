using System;
using System.Collections.Generic;
using System.Text;

namespace GCDCalculator
{
    public class GcdBitCalc : ICalculation
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

            int shift;

            if (a == 0)
                return b;

            if (b == 0)
                return a;

            for (shift = 0; ((a | b) & 1) == 0; ++shift)
            {
                a >>= 1;
                b >>= 1;
            }

            while ((a & 1) == 0)
                a >>= 1;
            do
            {
                while ((b & 1) == 0)
                    b >>= 1;

                if (a > b)
                {
                    int t = b;
                    b = a;
                    a = t;
                }

                b = b - a;

            } while (b != 0);

            return a << shift;
        }
    }
}
