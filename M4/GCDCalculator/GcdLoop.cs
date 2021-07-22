using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace GCDCalculator
{
    public class GcdLoop : ICalculation
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

            int temp;
            while (b != 0)
            {
                temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
    }
}
